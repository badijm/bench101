using bench101.Pooling;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Buffers;
using System.Linq;

namespace bench101
{
    public enum Gender
    {
        Male = 1, Female = 2
    }
    [RyuJitX64Job]
    [RankColumn]
    [MemoryDiagnoser]
    [CoreJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class PoolingBenchmark
    {
        private static readonly DataClass[] _items = new DataClass[]
        {
            new DataClass { Age = 12, Description = "Random" },
            new DataClass { Age = 13, Description = "Random2" },
            new DataClass { Age = 14, Description = "Random3" },
            new DataClass { Age = 15, Description = "Random3" },

            new DataClass { Age = 12, Description = "Random" },
            new DataClass { Age = 13, Description = "Random2" },
            new DataClass { Age = 14, Description = "Random3" },
            new DataClass { Age = 15, Description = "Random3" },

            new DataClass { Age = 12, Description = "Random" },
            new DataClass { Age = 13, Description = "Random2" },
            new DataClass { Age = 14, Description = "Random3" },
            new DataClass { Age = 15, Description = "Random3" },

            new DataClass { Age = 12, Description = "Random" },
            new DataClass { Age = 13, Description = "Random2" },
            new DataClass { Age = 14, Description = "Random3" },
            new DataClass { Age = 15, Description = "Random3" },
        };
        private int _itemsCount = 16;

        [Benchmark(Baseline = true)]
        public double VersionObjectArray()
        {
            DataClass[] data = new DataClass[_itemsCount];
            for (int i = 0; i < _itemsCount; ++i)
            {
                data[i] = new DataClass
                {
                    Age = _items[i].Age,
                    Gender = Helper(_items[i].Description)
                                 ? Gender.Female : Gender.Male
                };
            }
            return ProcessBatch(data);
        }

        [Benchmark]
        public double VersionClassArrayPool()
        {
            DataClass[] data = ArrayPool<DataClass>.Shared.Rent(_itemsCount);
            for (int i = 0; i < _itemsCount; ++i)
            {
                data[i] = new DataClass();
                data[i].Age = _items[i].Age;
                data[i].Gender = Helper(_items[i].Description)
                                 ? Gender.Female : Gender.Male;
            }
            double result = ProcessBatch(data);
            ArrayPool<DataClass>.Shared.Return(data);
            return result;
        }

        [Benchmark]
        public unsafe double VersionStructStackalloc()
        {
            Span<DataStruct> data = stackalloc DataStruct[_itemsCount];
            for (int i = 0; i < _items.Count(); ++i)
            {
                data[i].Age = _items[i].Age;
                data[i].Gender = Helper(_items[i].Description)
                                 ? Gender.Female : Gender.Male;
            }
            return ProcessBatch(data);
        }

        private bool Helper(string description)
        {
            return description == "Female";
        }

        private double ProcessBatch(DataClass[] data)
        {
            double result = default;
            foreach (var item in data)
            {
                result += item.Age;
            }
            return result;
        }

        private double ProcessBatch(Span<DataStruct> data)
        {
            double result = default;
            foreach (var item in data)
            {
                result += item.Age;
            }
            return result;
        }
    }
}
