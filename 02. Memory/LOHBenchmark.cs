using BenchmarkDotNet.Attributes;

namespace bench.core.GC
{
    [RankColumn]
    [MemoryDiagnoser]
    public class LOHBenchmark
    {
        [Benchmark]
        public byte[] Allocate84900()
        {
            return new byte[84900];
        }
        [Benchmark]
        public byte[] Allocate85000()
        {
            return new byte[85000];
        }
    }
}
