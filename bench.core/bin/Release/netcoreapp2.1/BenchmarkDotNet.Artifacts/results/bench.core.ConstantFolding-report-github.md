``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338439 Hz, Resolution=427.6357 ns, Timer=TSC
.NET Core SDK=3.1.101
  [Host]     : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-QAGAXO : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  RyuJitX64  : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT

Jit=RyuJit  Platform=X64  

```
| Method |       Job |       Runtime |      Mean |     Error |    StdDev |    Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |---------- |-------------- |----------:|----------:|----------:|----------:|------:|------:|------:|----------:|
| Sqrt13 |   Default |    .NET 4.6.1 |        NA |        NA |        NA |        NA |     - |     - |     - |         - |
| Sqrt14 |   Default |    .NET 4.6.1 |        NA |        NA |        NA |        NA |     - |     - |     - |         - |
| Sqrt13 |   Default | .NET Core 3.1 | 0.0024 ns | 0.0102 ns | 0.0090 ns | 0.0000 ns |     - |     - |     - |         - |
| Sqrt14 |   Default | .NET Core 3.1 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     - |     - |     - |         - |
| Sqrt13 | RyuJitX64 | .NET Core 2.1 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     - |     - |     - |         - |
| Sqrt14 | RyuJitX64 | .NET Core 2.1 | 0.0226 ns | 0.0077 ns | 0.0069 ns | 0.0221 ns |     - |     - |     - |         - |

Benchmarks with issues:
  ConstantFolding.Sqrt13: Job-QMEPFD(Runtime=.NET 4.6.1)
  ConstantFolding.Sqrt14: Job-QMEPFD(Runtime=.NET 4.6.1)
