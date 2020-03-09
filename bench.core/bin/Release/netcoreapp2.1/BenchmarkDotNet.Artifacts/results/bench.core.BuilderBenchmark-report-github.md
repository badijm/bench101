``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338439 Hz, Resolution=427.6357 ns, Timer=TSC
.NET Core SDK=3.1.101
  [Host]     : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-APQBGZ : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  RyuJitX64  : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT

Jit=RyuJit  Platform=X64  

```
|          Method |       Job |       Runtime | Count |         Mean |       Error |      StdDev | Rank |       Gen 0 |       Gen 1 |       Gen 2 |     Allocated |
|---------------- |---------- |-------------- |------ |-------------:|------------:|------------:|-----:|------------:|------------:|------------:|--------------:|
| **GetConcatenated** |   **Default** | **.NET Core 3.1** |   **200** |  **10,809.9 us** |   **114.28 us** |    **95.43 us** |    **6** |  **36781.2500** |           **-** |           **-** |   **75710.49 KB** |
|      GetBuilder |   Default | .NET Core 3.1 |   200 |     236.0 us |     2.57 us |     2.28 us |    1 |     76.6602 |      0.4883 |           - |     160.28 KB |
| GetConcatenated | RyuJitX64 | .NET Core 2.1 |   200 |  10,379.0 us |    74.39 us |    65.94 us |    5 |  36796.8750 |           - |           - |   75744.91 KB |
|      GetBuilder | RyuJitX64 | .NET Core 2.1 |   200 |     253.5 us |     1.70 us |     1.59 us |    2 |     87.4023 |      0.9766 |           - |     182.58 KB |
| **GetConcatenated** |   **Default** | **.NET Core 3.1** |  **1000** | **324,564.4 us** | **6,308.20 us** | **8,202.44 us** |    **7** | **630000.0000** | **545000.0000** | **545000.0000** | **1906538.52 KB** |
|      GetBuilder |   Default | .NET Core 3.1 |  1000 |   1,253.7 us |    10.42 us |     9.75 us |    3 |    152.3438 |     82.0313 |     82.0313 |     771.13 KB |
| GetConcatenated | RyuJitX64 | .NET Core 2.1 |  1000 | 320,517.2 us | 6,334.37 us | 6,777.71 us |    7 | 630000.0000 | 545500.0000 | 545500.0000 | 1906415.93 KB |
|      GetBuilder | RyuJitX64 | .NET Core 2.1 |  1000 |   1,323.4 us |     7.86 us |     6.56 us |    4 |    191.4063 |     82.0313 |     82.0313 |      877.2 KB |
