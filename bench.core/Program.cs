using BenchmarkDotNet.Running;
using System;
using System.Linq;
using System.Reflection;

namespace bench.core
{
    class Program
    {
        static void Main(string[] args) => BenchmarkRunner.Run(ParseArgs(args));

        private static Type ParseArgs(string[] args)
        {
            if (!args.Any())
            {
                Console.WriteLine($"\nSpecify valid test name");
                return null;
            }
            var availableBenchmarks = Assembly.GetExecutingAssembly().GetExportedTypes().Where(x => x.Name.EndsWith("Benchmark"));
            return availableBenchmarks.FirstOrDefault(x => x.Name == args[0]);
        }
    }
}
