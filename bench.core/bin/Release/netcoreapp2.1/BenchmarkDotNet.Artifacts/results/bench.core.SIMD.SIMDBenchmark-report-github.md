``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17134.1304 (1803/April2018Update/Redstone4)
AMD FX(tm)-8300, 1 CPU, 8 logical and 4 physical cores
Frequency=14318180 Hz, Resolution=69.8413 ns, Timer=HPET
.NET Core SDK=3.1.101
  [Host]     : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-MXGLXZ : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|      Method |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD | Rank |
|------------ |---------:|---------:|---------:|---------:|------:|--------:|-----:|
|  SumVectorT | 272.9 ns |  6.12 ns | 13.94 ns | 268.1 ns |  0.47 |    0.03 |    1 |
| SumUnrolled | 415.9 ns |  8.28 ns |  7.75 ns | 411.2 ns |  0.74 |    0.03 |    2 |
|         Sum | 583.1 ns | 12.07 ns | 34.24 ns | 575.4 ns |  1.00 |    0.00 |    3 |
