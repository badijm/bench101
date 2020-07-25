using System;
using BenchmarkDotNet.Attributes;

namespace bench.core._01._CPU.Other
{
    //https://github.com/dotnet/coreclr/pull/24584
    [ShortRunJob]
    public class DivBenchmark
    {
        [Benchmark]
        [Arguments(MathF.PI)]
        public float Div_old(float value)
        {
            for (int i = 0; i < 10; i++)
                value = value / 2f;
            return value;
        }

        [Benchmark(Baseline = true)]
        [Arguments(MathF.PI)]
        public float Div_new(float value)
        {
            for (int i = 0; i < 10; i++)
                value = value * 0.5f;
            return value;
        }
    }
}
