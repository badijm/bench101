``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338439 Hz, Resolution=427.6357 ns, Timer=TSC
.NET Core SDK=3.1.101
  [Host]     : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-XLCHJY : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|      Method |       Mean |   Error |  StdDev | Ratio | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |-----------:|--------:|--------:|------:|-----:|------:|------:|------:|----------:|
|  SumVectorT |   439.1 ns | 2.00 ns | 1.87 ns |  0.40 |    1 |     - |     - |     - |         - |
| SumUnrolled |   751.4 ns | 3.51 ns | 3.29 ns |  0.69 |    2 |     - |     - |     - |         - |
|         Sum | 1,091.7 ns | 3.27 ns | 2.90 ns |  1.00 |    3 |     - |     - |     - |         - |
