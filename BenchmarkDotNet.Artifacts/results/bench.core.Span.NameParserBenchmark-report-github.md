``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338437 Hz, Resolution=427.6361 ns, Timer=TSC
.NET Core SDK=5.0.100-preview.2.20176.6
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|                    Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |----------:|----------:|----------:|------:|--------:|-----:|-------:|------:|------:|----------:|
|       GetLastNameWithSpan |  17.94 ns |  0.419 ns |  0.465 ns |  0.04 |    0.00 |    1 |      - |     - |     - |         - |
| GetLastNameUsingSubstring | 111.39 ns |  2.481 ns |  4.006 ns |  0.24 |    0.02 |    2 | 0.0191 |     - |     - |      40 B |
|               GetLastName | 472.52 ns | 17.816 ns | 51.117 ns |  1.00 |    0.00 |    3 | 0.0687 |     - |     - |     144 B |
