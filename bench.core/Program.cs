using bench.core.Others;
using bench.core.SIMD;
using bench.core.Span;
using bench101;
using BenchmarkDotNet.Running;
using System;
using System.IO;
using System.Linq;

namespace bench.core
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args.Any())
            {
                var directories = Directory.EnumerateDirectories(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName)
                    .Where(x => !x.Contains("bin") || !x.Contains("obj"))
                    .Select((directory, number) => $"{++number}\t{directory}");

                Console.WriteLine($"\nSpecify test name\n Choose from following folders in project:\n {string.Join("\n", directories)}");
                return;
            }
            switch (args[0])
            {
                case var arg when arg == nameof(Pooling): BenchmarkRunner.Run<Pooling>(); return;
                case var arg when arg == nameof(Builder): BenchmarkRunner.Run<Builder>(); return;
                case var arg when arg == nameof(SumBenchmark): BenchmarkRunner.Run<SumBenchmark>(); return;
                default:
                    Console.WriteLine($"\nSpecify valid test name"); return;
            }
        }
    }
}
