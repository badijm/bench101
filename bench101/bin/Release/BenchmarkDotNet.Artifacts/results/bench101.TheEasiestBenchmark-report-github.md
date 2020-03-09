``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338437 Hz, Resolution=427.6361 ns, Timer=TSC
  [Host]     : .NET Framework 4.7.2 (4.7.3062.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.7.2 (4.7.3062.0), X86 LegacyJIT


```
|           Method |     Mean |     Error |    StdDev |
|----------------- |---------:|----------:|----------:|
|    &#39;Summ1M Linq&#39; |       NA |        NA |        NA |
| &#39;Summ1M Foreach&#39; | 1.162 ms | 0.0039 ms | 0.0035 ms |

Benchmarks with issues:
  TheEasiestBenchmark.'Summ1M Linq': DefaultJob
