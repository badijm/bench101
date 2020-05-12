``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338440 Hz, Resolution=427.6355 ns, Timer=TSC
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|           Method | Count |          Mean |        Error |       StdDev |       Gen 0 |       Gen 1 |       Gen 2 |    Allocated |
|----------------- |------ |--------------:|-------------:|-------------:|------------:|------------:|------------:|-------------:|
|        **UseString** |    **10** |      **66.78 μs** |     **0.518 μs** |     **0.459 μs** |    **105.7129** |           **-** |           **-** |    **216.05 KB** |
| UseStringBuilder |    10 |      18.79 μs |     0.195 μs |     0.173 μs |      4.0283 |           - |           - |      8.29 KB |
|        **UseString** |   **100** |   **4,394.25 μs** |    **31.529 μs** |    **26.328 μs** |   **8609.3750** |           **-** |           **-** |  **17648.01 KB** |
| UseStringBuilder |   100 |     174.41 μs |     2.612 μs |     2.315 μs |     37.3535 |           - |           - |     76.91 KB |
|        **UseString** |  **1000** | **494,518.65 μs** | **6,164.963 μs** | **5,766.710 μs** | **586000.0000** | **507000.0000** | **507000.0000** | **1771582.8 KB** |
| UseStringBuilder |  1000 |   1,839.82 μs |    30.425 μs |    54.862 μs |    140.6250 |     82.0313 |     82.0313 |    742.89 KB |
