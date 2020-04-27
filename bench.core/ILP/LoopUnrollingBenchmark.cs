using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace bench.core
{
    //https://en.wikipedia.org/wiki/Loop_unrolling
    [RankColumn]
    public class LoopUnrollingBenchmark
    {
        [Params(100, 1000/*, 10_000*/)]
        public static int size;

        [ParamsSource(nameof(ValuesForArray))]
        public double[] array1D;

        public static IEnumerable<int[,]> ValuesForArray()
        {
            yield return new int[size, size];
        }

        [Benchmark(Baseline = true)]
        public double NormalLoop()
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
                sum += array1D[i];
            return sum;
        }

        [Benchmark]
        public void UnrolledLoop()
        {
            double sum = 0;
            for (int i = 0; i < size; i += 4)
                sum += array1D[i] + array1D[i + 1] + array1D[i + 2] + array1D[i + 3];
        }
    }
}
