``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338439 Hz, Resolution=427.6357 ns, Timer=TSC
.NET Core SDK=3.1.101
  [Host]     : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  DefaultJob : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT


```
|                    Method |      Mean |    Error |   StdDev | Ratio | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |----------:|---------:|---------:|------:|-----:|-------:|------:|------:|----------:|
|       GetLastNameWithSpan |  33.64 ns | 0.095 ns | 0.084 ns |  0.09 |    1 |      - |     - |     - |         - |
| GetLastNameUsingSubstring | 107.03 ns | 0.432 ns | 0.338 ns |  0.30 |    2 | 0.0190 |     - |     - |      40 B |
|               GetLastName | 355.79 ns | 1.313 ns | 1.164 ns |  1.00 |    3 | 0.0758 |     - |     - |     160 B |
