using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace bench.core.CPUCache
{
    [RankColumn]
    public class LocalityBenchmark
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
        public void RowTraversal()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    array2D[x, y] = x * y;
        }

        [Benchmark]
        public void ColumnTraversal()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    array2D[y, x] = x * y;
        }
    }
}
