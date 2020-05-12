``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338434 Hz, Resolution=427.6366 ns, Timer=TSC
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  Job-LEPNUD : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|             Method |        Job |       Runtime |     Mean |    Error |   StdDev | Ratio | RatioSD |
|------------------- |----------- |-------------- |---------:|---------:|---------:|------:|--------:|
|     GetIndexSimple | Job-QUTXYI |    .NET 4.7.2 |       NA |       NA |       NA |     ? |       ? |
|    GetIndexLibrary | Job-QUTXYI |    .NET 4.7.2 |       NA |       NA |       NA |     ? |       ? |
| GetIndexIntrinsics | Job-QUTXYI |    .NET 4.7.2 |       NA |       NA |       NA |     ? |       ? |
|                    |            |               |          |          |          |       |         |
|     GetIndexSimple | Job-LEPNUD | .NET Core 3.1 | 53.93 μs | 0.167 μs | 0.140 μs |  1.00 |    0.00 |
|    GetIndexLibrary | Job-LEPNUD | .NET Core 3.1 | 30.61 μs | 0.189 μs | 0.167 μs |  0.57 |    0.00 |
| GetIndexIntrinsics | Job-LEPNUD | .NET Core 3.1 | 53.62 μs | 0.183 μs | 0.162 μs |  0.99 |    0.00 |

Benchmarks with issues:
  GetIndexBenchmark.GetIndexSimple: Job-QUTXYI(Runtime=.NET 4.7.2)
  GetIndexBenchmark.GetIndexLibrary: Job-QUTXYI(Runtime=.NET 4.7.2)
  GetIndexBenchmark.GetIndexIntrinsics: Job-QUTXYI(Runtime=.NET 4.7.2)
