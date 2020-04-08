``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.1098 (1809/October2018Update/Redstone5)
Intel Xeon CPU E3-1505M v6 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|        Method |     Mean |     Error |    StdDev |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|-------------- |---------:|----------:|----------:|--------:|--------:|--------:|----------:|
| Allocate84900 | 3.969 us | 0.0793 us | 0.0779 us | 19.9966 |       - |       - |  82.94 KB |
| Allocate85000 | 5.438 us | 0.1079 us | 0.1060 us | 27.0233 | 27.0233 | 27.0233 |  83.03 KB |
