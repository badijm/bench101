``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338439 Hz, Resolution=427.6357 ns, Timer=TSC
.NET Core SDK=3.1.101
  [Host]     : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-CNEZDE : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  RyuJitX64  : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT

Jit=RyuJit  Platform=X64  Runtime=.NET Core 2.1  

```
|                  Method |       Job |     Mean |    Error |   StdDev | Ratio | RatioSD | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |---------- |---------:|---------:|---------:|------:|--------:|-----:|-------:|------:|------:|----------:|
|      VersionObjectArray |   Default | 288.5 ns |  5.79 ns | 10.29 ns |  1.00 |    0.00 |    1 | 0.3161 |     - |     - |     664 B |
|   VersionClassArrayPool |   Default | 360.2 ns |  3.24 ns |  3.03 ns |  1.23 |    0.03 |    2 | 0.2437 |     - |     - |     512 B |
| VersionStructStackalloc |   Default | 841.0 ns | 20.13 ns | 23.18 ns |  2.88 |    0.12 |    3 |      - |     - |     - |         - |
|                         |           |          |          |          |       |         |      |        |       |       |           |
|      VersionObjectArray | RyuJitX64 | 271.4 ns |  8.72 ns | 11.33 ns |  1.00 |    0.00 |    1 | 0.3161 |     - |     - |     664 B |
|   VersionClassArrayPool | RyuJitX64 | 349.3 ns |  7.00 ns | 13.99 ns |  1.29 |    0.05 |    2 | 0.2437 |     - |     - |     512 B |
| VersionStructStackalloc | RyuJitX64 | 852.3 ns | 34.91 ns | 41.56 ns |  3.14 |    0.22 |    3 |      - |     - |     - |         - |
