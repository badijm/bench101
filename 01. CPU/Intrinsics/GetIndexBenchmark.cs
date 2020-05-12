using System;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using BenchmarkDotNet.Attributes;

namespace bench.core.Intrinsics
{
    public class GetIndexBenchmark
    {
        private const int ElementCount = 100_000;
        private const int searchValue = 1337;
        private readonly int[] testElements = new int[ElementCount];

        [GlobalSetup]
        public void GlobalSetup()
        {
            testElements[50_000] = searchValue;
        }

        [Benchmark(Baseline = true)]
        public int GetIndexSimple() => SpanIndexOf.GetIndexSimple(testElements, searchValue);

        [Benchmark]
        public int GetIndexLibrary() => SpanIndexOf.GetIndexLibrary(testElements, searchValue);

        [Benchmark]
        public int GetIndexIntrinsics() => SpanIndexOf.GetIndexIntrinsics(testElements, searchValue);
    }

    public static class SpanIndexOf
    {
        /// <summary> Implemented with a simple loop </summary>
        public static int GetIndexSimple(ReadOnlySpan<int> span, int item)
        {
            for (int i = 0; i < span.Length; i++)
            {
                if (span[i] == item)
                    return i;
            }

            return -1;
        }

        /// <summary> Implemented using build-in library 'IndexOf'</summary>
        public static int GetIndexLibrary(ReadOnlySpan<int> span, int item)
        {
            return span.IndexOf(item);
        }

        /// <summary> Implemented using 'Avx2' intrinsics</summary>
        /// <remarks> Without 'Avx2' support will behave as a simple loop</remarks>
        public static unsafe int GetIndexIntrinsics(ReadOnlySpan<int> span, int item)
        {
            // Get a fixed pointer so the garbage-collector doesn't move the collection
            fixed (int* startPointer = span)
            {
                int* endPointer = startPointer + span.Length;
                int* pointer = startPointer;

                // Query if the cpu actually supports 'Avx2' instructions 
                if (Avx2.IsSupported)
                {
                    // Load '1' item into a 128 bit vector
                    Vector128<int> itemScaler = Sse2.LoadScalarVector128(&item);

                    // Copy that first item into the other 7 slots of a 256 bit vector, this means
                    // we now have a vector that is holding 8 times the value 'item'
                    Vector256<int> itemVector = Avx2.BroadcastScalarToVector256(itemScaler);

                    // Loop through the span 8 elements at a time (256 bit / 32 bit = 8)
                    for (; pointer + 8 < endPointer; pointer += 8)
                    {
                        // Load 8 elements from the span
                        Vector256<int> elements = Avx.LoadVector256(pointer);

                        // Compare those 8 elements with our item. This will give us 8 values of
                        // 'FFFF' or '0000' (32 bits of either 1 or 0) in a 256 bit vector
                        Vector256<int> elementEquals = Avx2.CompareEqual(elements, itemVector);

                        /*
                        Because 256 bit is a too big type to work with we combine it into a single
                        integer by taking 4 bits from each 32 bit value (bit 7, 15, 23 and 31).

                        eq 32:       0        0        1        0        0        0        0        0        0
                        MoveMask: 0 0 0 0  0 0 0 0  1 1 1 1  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
                        Hex:         0        0        F        0        0        0        0        0        0
                        */

                        int mask = Avx2.MoveMask(elementEquals.AsByte());

                        // If we make the assumption that the item only exists in the span once then
                        // we can construct a jump table for it.
                        switch (mask)
                        {
                            case 0x0000000F: // At element 0
                                return (int)(pointer - startPointer);

                            case 0x000000F0: // At element 1
                                return (int)(pointer + 1 - startPointer);

                            case 0x00000F00: // At element 2
                                return (int)(pointer + 2 - startPointer);

                            case 0x0000F000: // At element 3
                                return (int)(pointer + 3 - startPointer);

                            case 0x000F0000: // At element 4
                                return (int)(pointer + 4 - startPointer);

                            case 0x00F00000: // At element 5
                                return (int)(pointer + 5 - startPointer);

                            case 0x0F000000: // At element 6
                                return (int)(pointer + 6 - startPointer);

                            case unchecked((int)0xF0000000): // At element 7
                                return (int)(pointer + 7 - startPointer);

                            case 0x00000000: // Not found
                                continue;

                            default:
                                throw new Exception("Item found in span multiple times");
                        }
                    }
                }

                // Handle the remaiming items with a simple loop
                for (; pointer < endPointer; pointer++)
                {
                    if (*pointer == item)
                        return (int)(pointer - startPointer);
                }
            }

            return -1;
        }
    }
}
