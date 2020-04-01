using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace bench.core.Other
{
    [MemoryDiagnoser]
    public class ListMemoryBenchmark
    {
        [Params(100, 1000, 10_000)]
        public int size;

        [Benchmark(Baseline = true)]
        public void Array()
        {
            var array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }
        }

        [Benchmark]
        public void ListFixedSize()
        {
            var list = new List<int>(size);
            for (int i = 0; i < size; i++)
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void ListDynamicSize()
        {
            var list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void HashSet()
        {
            var set = new HashSet<int>();
            for (int i = 0; i < size; i++)
            {
                set.Add(i);
            }
        }

        [Benchmark]
        public void Dictionary()
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < size; i++)
            {
                dic.Add(i, i);
            }
        }
    }
}
