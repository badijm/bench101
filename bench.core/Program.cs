using bench.core.SIMD;
using bench.core.Span;
using bench101;
using BenchmarkDotNet.Running;
using System;

namespace bench.core
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SIMDBenchmark>();
        }
    }
}
