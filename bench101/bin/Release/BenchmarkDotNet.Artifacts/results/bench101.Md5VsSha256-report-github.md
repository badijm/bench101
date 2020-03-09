``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338437 Hz, Resolution=427.6361 ns, Timer=TSC
  [Host]     : .NET Framework 4.7.2 (4.7.3062.0), X86 LegacyJIT
  Job-SWSWQT : .NET Framework 4.7.2 (4.7.3062.0), X86 LegacyJIT


```
| Method |       Runtime |     N |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------- |-------------- |------ |-----------:|----------:|----------:|------:|--------:|
| **Sha256** |    **.NET 4.7.2** |  **1000** |  **22.040 us** | **0.1052 us** | **0.0879 us** |  **1.00** |    **0.00** |
| Sha256 | .NET Core 3.0 |  1000 |         NA |        NA |        NA |     ? |       ? |
|        |               |       |            |           |           |       |         |
|    Md5 |    .NET 4.7.2 |  1000 |   7.832 us | 0.0287 us | 0.0255 us |  1.00 |    0.00 |
|    Md5 | .NET Core 3.0 |  1000 |         NA |        NA |        NA |     ? |       ? |
|        |               |       |            |           |           |       |         |
| **Sha256** |    **.NET 4.7.2** | **10000** | **207.917 us** | **0.3350 us** | **0.3134 us** |  **1.00** |    **0.00** |
| Sha256 | .NET Core 3.0 | 10000 |         NA |        NA |        NA |     ? |       ? |
|        |               |       |            |           |           |       |         |
|    Md5 |    .NET 4.7.2 | 10000 |  39.207 us | 0.1025 us | 0.0959 us |  1.00 |    0.00 |
|    Md5 | .NET Core 3.0 | 10000 |         NA |        NA |        NA |     ? |       ? |

Benchmarks with issues:
  Md5VsSha256.Sha256: Job-FHEAYO(Runtime=.NET Core 3.0) [N=1000]
  Md5VsSha256.Md5: Job-FHEAYO(Runtime=.NET Core 3.0) [N=1000]
  Md5VsSha256.Sha256: Job-FHEAYO(Runtime=.NET Core 3.0) [N=10000]
  Md5VsSha256.Md5: Job-FHEAYO(Runtime=.NET Core 3.0) [N=10000]
