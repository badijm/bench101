using System;
using BenchmarkDotNet.Attributes;

namespace bench.core._01._CPU.Other
{
    //https://github.com/dotnet/coreclr/pull/25856
    public class Fmadd
    {
        [Benchmark(Baseline = true)]
        [Arguments(42.51f, 1 / 3f, 100)]
        public float Old(float a, float b, int iterations)
        {
            float z = 1f;
            for (int i = 0; i < iterations; i++)
                z = z * a + b;
            return z;
        }

        [Benchmark]
        [Arguments(42.51f, 1 / 3f, 100)]
        public float New(float a, float b, int iterations)
        {
            float z = 1f;
            for (int i = 0; i < iterations; i++)
                z = MathF.FusedMultiplyAdd(z, a, b); // let's pretend JIT generates it
            return z;
        }
    }
}
