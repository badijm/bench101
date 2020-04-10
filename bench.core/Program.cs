using BenchmarkDotNet.Running;
using System;
using System.Linq;
using System.Reflection;

namespace bench.core
{
    class Program
    {
        static void Main(string[] args)
        {
            var toRun = ParseArgs(args);
            if (toRun == null) return;
            BenchmarkRunner.Run(toRun);
        }

        private static Type ParseArgs(string[] args)
        {
            var availableBenchmarks = Assembly.GetExecutingAssembly().GetExportedTypes().Where(x => x.Name.EndsWith("Benchmark"));
            return args == null || !args.Any() ? null : availableBenchmarks.FirstOrDefault(x => x.Name == args[0]);
        }
    }
}
