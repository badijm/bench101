``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.1098 (1809/October2018Update/Redstone5)
Intel Xeon CPU E3-1505M v6 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|                    Method |       Mean |     Error |     StdDev | Ratio | RatioSD | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |-----------:|----------:|-----------:|------:|--------:|-----:|-------:|------:|------:|----------:|
|               GetLastName | 204.111 ns | 7.4825 ns | 21.7080 ns |  1.00 |    0.00 |    3 | 0.0420 |     - |     - |     176 B |
| GetLastNameUsingSubstring |  54.702 ns | 1.1302 ns |  3.0556 ns |  0.27 |    0.03 |    2 | 0.0095 |     - |     - |      40 B |
|       GetLastNameWithSpan |   8.086 ns | 0.1658 ns |  0.1551 ns |  0.04 |    0.00 |    1 |      - |     - |     - |         - |
