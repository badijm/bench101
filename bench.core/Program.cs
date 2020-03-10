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
                var projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
                var directories = Directory.EnumerateDirectories(projectRoot.FullName)
                    .Where(x => !x.Contains("bin"))
                    .Where(x => !x.Contains("obj"))
                    .Select((directory, number) => $"{number}\t{directory}");

                Console.WriteLine($"\nSpecify test name\n Choose from following folders in project {string.Join("\n", directories)}");
                return;
            }
            if (args[0] == nameof(Pooling))
                BenchmarkRunner.Run<Pooling>();

            else if (args[0] == nameof(Builder))
                BenchmarkRunner.Run<Builder>();

            else if (args[0] == nameof(SumBenchmark))
                BenchmarkRunner.Run<SumBenchmark>();
        }
    }
}
