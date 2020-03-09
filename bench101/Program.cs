using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace bench101
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<PoolingBenchmark>();
        }
    }
}
