using System;
using System.Linq;
using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
namespace bench.core.SIMD
{
    [RankColumn]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class SIMDBenchmark
    {
        public static int[] Data = GetRandomArray();

        [Benchmark(Baseline = true)]
        public int Sum()
        {
            var source = Data.AsSpan();

            int result = 0;

            for (int i = 0; i < source.Length; i++)
            {
                result += source[i];
            }

            return result;
        }

        [Benchmark]
        public unsafe int SumUnrolled()
        {
            var source = Data.AsSpan();

            int result = 0;

            int i = 0;
            int lastBlockIndex = source.Length - (source.Length % 4);

            // Pin source so we can elide the bounds checks
            fixed (int* pSource = source)
            {
                while (i < lastBlockIndex)
                {
                    result += pSource[i + 0];
                    result += pSource[i + 1];
                    result += pSource[i + 2];
                    result += pSource[i + 3];

                    i += 4;
                }

                while (i < source.Length)
                {
                    result += pSource[i];
                    i += 1;
                }
            }

            return result;
        }

        [Benchmark]
        public int SumVectorT()
        {
            int result = 0;
            var source = Data.AsSpan();

            Vector<int> vresult = Vector<int>.Zero;

            int i = 0;
            int lastBlockIndex = source.Length - (source.Length % Vector<int>.Count);

            while (i < lastBlockIndex)
            {
                vresult += new Vector<int>(source.Slice(i));
                i += Vector<int>.Count;
            }

            for (int n = 0; n < Vector<int>.Count; n++)
            {
                result += vresult[n];
            }

            while (i < source.Length)
            {
                result += source[i];
                i += 1;
            }

            return result;
        }

        //public int SumVectorized(ReadOnlySpan<int> source)
        //{
        //    if (Sse2.IsSupported)
        //    {
        //        return SumVectorizedSse2(source);
        //    }
        //    else
        //    {
        //        return SumVectorT(source);
        //    }
        //}

        //private unsafe int SumVectorizedSse2(ReadOnlySpan<int> source)
        //{
        //    int result;

        //    fixed (int* pSource = source)
        //    {
        //        Vector128<int> vresult = Vector128<int>.Zero;

        //        int i = 0;
        //        int lastBlockIndex = source.Length - (source.Length % 4);

        //        while (i < lastBlockIndex)
        //        {
        //            vresult = Sse2.Add(vresult, Sse2.LoadVector128(pSource + i));
        //            i += 4;
        //        }

        //        if (Ssse3.IsSupported)
        //        {
        //            vresult = Ssse3.HorizontalAdd(vresult, vresult);
        //            vresult = Ssse3.HorizontalAdd(vresult, vresult);
        //        }
        //        else
        //        {
        //            vresult = Sse2.Add(vresult, Sse2.Shuffle(vresult, 0x4E));
        //            vresult = Sse2.Add(vresult, Sse2.Shuffle(vresult, 0xB1));
        //        }
        //        result = vresult.ToScalar();

        //        while (i < source.Length)
        //        {
        //            result += pSource[i];
        //            i += 1;
        //        }
        //    }

        //    return result;
        //}

        private static int[] GetRandomArray(int size = 1000, int min = int.MinValue, int max = int.MaxValue)
        {
            var rand = new Random();
            return Enumerable
                .Repeat(0, size)
                .Select(i => rand.Next(min, max))
                .ToArray();
        }
    }
}
