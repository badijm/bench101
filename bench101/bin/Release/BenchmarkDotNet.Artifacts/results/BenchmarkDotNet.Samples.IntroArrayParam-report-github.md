``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338437 Hz, Resolution=427.6361 ns, Timer=TSC
  [Host]     : .NET Framework 4.7.2 (4.7.3062.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.7.2 (4.7.3062.0), X86 LegacyJIT


```
|        Method |          array | value |       Mean |     Error |    StdDev |     Median |
|-------------- |--------------- |------ |-----------:|----------:|----------:|-----------:|
|  **ArrayIndexOf** | **System.Int32[]** |     **4** |  **28.574 ns** | **0.6606 ns** | **1.4911 ns** |  **27.935 ns** |
|  ArrayIndexOf | System.Int32[] |     4 |  32.935 ns | 0.7117 ns | 0.8472 ns |  32.946 ns |
| ManualIndexOf | System.Int32[] |     4 |   7.462 ns | 0.2374 ns | 0.3625 ns |   7.346 ns |
| ManualIndexOf | System.Int32[] |     4 |  11.440 ns | 0.0771 ns | 0.0722 ns |  11.424 ns |
|  **ArrayIndexOf** | **System.Int32[]** |   **101** | **199.625 ns** | **0.7492 ns** | **0.7008 ns** | **199.391 ns** |
| ManualIndexOf | System.Int32[] |   101 | 141.187 ns | 0.9126 ns | 0.8537 ns | 140.848 ns |
