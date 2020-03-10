using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace bench.core.Others
{
    [RyuJitX64Job]
    [DisassemblyDiagnoser]
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
}
