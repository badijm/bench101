``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338434 Hz, Resolution=427.6366 ns, Timer=TSC
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  Job-LTDIQI : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|        Method |        Job |       Runtime |       Mean |    Error |   StdDev |     Median | Ratio | RatioSD |
|-------------- |----------- |-------------- |-----------:|---------:|---------:|-----------:|------:|--------:|
|           Sum | Job-AWXOKG |    .NET 4.7.2 |         NA |       NA |       NA |         NA |     ? |       ? |
|   SumUnrolled | Job-AWXOKG |    .NET 4.7.2 |         NA |       NA |       NA |         NA |     ? |       ? |
|    SumVectorT | Job-AWXOKG |    .NET 4.7.2 |         NA |       NA |       NA |         NA |     ? |       ? |
| SumVectorized | Job-AWXOKG |    .NET 4.7.2 |         NA |       NA |       NA |         NA |     ? |       ? |
|               |            |               |            |          |          |            |       |         |
|           Sum | Job-LTDIQI | .NET Core 3.1 | 1,093.0 ns |  6.04 ns |  5.65 ns | 1,093.2 ns |  1.00 |    0.00 |
|   SumUnrolled | Job-LTDIQI | .NET Core 3.1 |   776.6 ns | 15.30 ns | 17.62 ns |   774.8 ns |  0.71 |    0.02 |
|    SumVectorT | Job-LTDIQI | .NET Core 3.1 |   438.2 ns |  8.37 ns | 13.03 ns |   433.8 ns |  0.41 |    0.01 |
| SumVectorized | Job-LTDIQI | .NET Core 3.1 |   336.2 ns |  6.73 ns | 18.88 ns |   327.4 ns |  0.31 |    0.02 |

Benchmarks with issues:
  SumBenchmark.Sum: Job-AWXOKG(Runtime=.NET 4.7.2)
  SumBenchmark.SumUnrolled: Job-AWXOKG(Runtime=.NET 4.7.2)
  SumBenchmark.SumVectorT: Job-AWXOKG(Runtime=.NET 4.7.2)
  SumBenchmark.SumVectorized: Job-AWXOKG(Runtime=.NET 4.7.2)
