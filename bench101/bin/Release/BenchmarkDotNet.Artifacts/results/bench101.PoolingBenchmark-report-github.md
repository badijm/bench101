``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338439 Hz, Resolution=427.6357 ns, Timer=TSC
  [Host]       : .NET Framework 4.7.2 (4.7.3062.0), X86 LegacyJIT
  LegacyJitX64 : .NET Framework 4.7.2 (4.7.3062.0), X64 LegacyJIT
  RyuJitX64    : .NET Framework 4.7.2 (4.7.3062.0), X64 RyuJIT

Platform=X64  

```
|                Method |          Job |       Jit |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |
|---------------------- |------------- |---------- |---------:|---------:|---------:|---------:|------:|--------:|
|    VersionObjectArray | LegacyJitX64 | LegacyJit | 377.1 ns |  1.91 ns |  1.70 ns | 377.5 ns |  1.00 |    0.00 |
| VersionClassArrayPool | LegacyJitX64 | LegacyJit | 491.6 ns | 12.56 ns | 20.64 ns | 486.0 ns |  1.33 |    0.06 |
|                       |              |           |          |          |          |          |       |         |
|    VersionObjectArray |    RyuJitX64 |    RyuJit | 408.5 ns | 12.96 ns | 36.77 ns | 393.4 ns |  1.00 |    0.00 |
| VersionClassArrayPool |    RyuJitX64 |    RyuJit | 486.0 ns |  4.68 ns |  4.38 ns | 485.2 ns |  1.23 |    0.08 |
