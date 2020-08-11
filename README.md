
Repo containing CPU & memory benchmarks made w/ https://github.com/dotnet/BenchmarkDotNet

Example of BenchmarkDotNet result log

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.17763.1282 (1809/October2018Update/Redstone5)
Intel Xeon CPU E3-1505M v6 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

```
|             Method |      Mean |     Error |    StdDev | Ratio |
|------------------- |----------:|----------:|----------:|------:|
|     GetIndexSimple | 19.357 μs | 0.2918 μs | 0.2587 μs |  1.00 |
|    GetIndexLibrary | 11.569 μs | 0.1078 μs | 0.0900 μs |  0.60 |
| GetIndexIntrinsics |  6.095 μs | 0.0464 μs | 0.0412 μs |  0.31 |


