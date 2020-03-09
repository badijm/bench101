using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace bench.core
{
    [RyuJitX64Job]
    [LegacyJitX64Job]
    [MemoryDiagnoser]
    //[SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class ConstantFolding
    {
        [Benchmark]
        public double Sqrt13()
        {
            return Math.Sqrt(1) + Math.Sqrt(2) + Math.Sqrt(3) + Math.Sqrt(4) + Math.Sqrt(5) +
                   Math.Sqrt(6) + Math.Sqrt(7) + Math.Sqrt(8) + Math.Sqrt(9) + Math.Sqrt(10) +
                   Math.Sqrt(11) + Math.Sqrt(12) + Math.Sqrt(13);
        }
        [Benchmark]
        public double Sqrt14()
        {
            return Math.Sqrt(1) + Math.Sqrt(2) + Math.Sqrt(3) + Math.Sqrt(4) + Math.Sqrt(5) +
                   Math.Sqrt(6) + Math.Sqrt(7) + Math.Sqrt(8) + Math.Sqrt(9) + Math.Sqrt(10) +
                   Math.Sqrt(11) + Math.Sqrt(12) + Math.Sqrt(13) + Math.Sqrt(14);
        }
    }
}
