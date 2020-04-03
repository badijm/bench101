using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace bench.core
{
    //https://en.wikipedia.org/wiki/Loop_unrolling
    [RankColumn]
    public class LoopUnrollingBenchmark
    {
        [Params(100, 1000, 10_000)]
        public static int size;

        [ParamsSource(nameof(ValuesForArray))]
        public int[,] array2D;

        public static IEnumerable<int[,]> ValuesForArray()
        {
            yield return new int[size, size];
        }

        [Benchmark(Baseline = true)]
        public void NormalLoop()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    ProcessArray(array2D, x, y);
                }
            }
        }

        [Benchmark]
        public void UnrolledLoop()
        {
            for (int x = 0; x < size; x += 4)
            {
                for (int y = 0; y < size; y += 4)
                {
                    ProcessArray(array2D, x, y);
                    ProcessArray(array2D, x + 1, y + 1);
                    ProcessArray(array2D, x + 2, y + 2);
                    ProcessArray(array2D, x + 3, y + 3);
                }
            }
        }

        private void ProcessArray(int[,] array, int x, int y)
        {
            array[x, y] = x * y;
        }
    }
}
