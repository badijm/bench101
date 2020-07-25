using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace bench.core._01._CPU.Other
{
    //[LegacyJitX64Job]
    //[LegacyJitX86Job]
    [RankColumn]
    [ShortRunJob]
    [DisassemblyDiagnoser]
    public class LoopEvenOdd
    {

        [Benchmark(Baseline = true)]
        public void Iter_Even()
        {
            const int even = 10_000_001;
            var stopwatch1 = Stopwatch.StartNew();
            for (long i = 0; i < even; i++)
            {
                Foo();
            }
            stopwatch1.Stop();
        }

        private void Foo()
        {
        }

        [Benchmark]
        public void Iter_Odd()
        {
            const int odd = 10_000_002;
            var stopwatch2 = Stopwatch.StartNew();
            for (long i = 0; i < odd; i++)
            {
                Foo();
            }
            stopwatch2.Stop();
        }
    }
}
