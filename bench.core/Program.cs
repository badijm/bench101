using System;
using System.Linq;
using System.Reflection;
using bench.core.Other;
using BenchmarkDotNet.Running;

namespace bench.core
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args.Any())
            {
                BenchmarkRunner.Run<ListMemoryBenchmark>();
                return;
            }
            var availableBenchmarks = Assembly.GetExecutingAssembly().GetExportedTypes().Where(x => x.Name.EndsWith("Benchmark"));
            var benchmarkToRun = availableBenchmarks.FirstOrDefault(x => x.Name == args.First());
            if (benchmarkToRun == null)
            {
                Console.WriteLine($"\nSpecify valid test name");
                return;
            }
            BenchmarkRunner.Run(benchmarkToRun);
        }
    }
}
