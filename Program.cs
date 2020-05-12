using System;
using System.Linq;
using System.Reflection;
using BenchmarkDotNet.Running;

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

        private static Type ParseArgs(string[] args) => args == null || !args.Any() ? null : Assembly.GetExecutingAssembly().GetExportedTypes().Where(x => x.Name.EndsWith("Benchmark")).FirstOrDefault(x => x.Name == args[0]);
    }
}
