``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338440 Hz, Resolution=427.6355 ns, Timer=TSC
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  Job-NDQKKO : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT

Force=False  

```
|               Method | SizeInBytes |          Mean |        Error |       StdDev |        Median | Rank |    Gen 0 |    Gen 1 |    Gen 2 |  Allocated |
|--------------------- |------------ |--------------:|-------------:|-------------:|--------------:|-----:|---------:|---------:|---------:|-----------:|
|             **Allocate** |         **100** |      **23.13 ns** |     **0.293 ns** |     **0.260 ns** |      **23.12 ns** |    **1** |   **0.0612** |        **-** |        **-** |      **128 B** |
| RentAndReturn_Shared |         100 |      74.35 ns |     0.239 ns |     0.224 ns |      74.39 ns |    2 |        - |        - |        - |          - |
|  RentAndReturn_Aware |         100 |      87.51 ns |     0.574 ns |     0.479 ns |      87.41 ns |    6 |        - |        - |        - |          - |
|             **Allocate** |        **1000** |     **122.83 ns** |     **2.505 ns** |     **4.185 ns** |     **120.93 ns** |    **8** |   **0.4895** |        **-** |        **-** |     **1024 B** |
| RentAndReturn_Shared |        1000 |      84.77 ns |     0.128 ns |     0.107 ns |      84.76 ns |    5 |        - |        - |        - |          - |
|  RentAndReturn_Aware |        1000 |      87.38 ns |     0.183 ns |     0.171 ns |      87.34 ns |    6 |        - |        - |        - |          - |
|             **Allocate** |       **10000** |   **1,111.65 ns** |    **21.534 ns** |    **29.476 ns** |   **1,105.35 ns** |    **9** |   **4.7836** |        **-** |        **-** |    **10024 B** |
| RentAndReturn_Shared |       10000 |      77.95 ns |     0.354 ns |     0.331 ns |      77.92 ns |    4 |        - |        - |        - |          - |
|  RentAndReturn_Aware |       10000 |      86.64 ns |     0.220 ns |     0.195 ns |      86.63 ns |    6 |        - |        - |        - |          - |
|             **Allocate** |      **100000** |   **9,954.09 ns** |   **170.008 ns** |   **141.964 ns** |   **9,987.24 ns** |   **10** |  **31.2347** |  **31.2347** |  **31.2347** |   **100024 B** |
| RentAndReturn_Shared |      100000 |      74.77 ns |     0.187 ns |     0.156 ns |      74.69 ns |    2 |        - |        - |        - |          - |
|  RentAndReturn_Aware |      100000 |      87.48 ns |     0.211 ns |     0.187 ns |      87.47 ns |    6 |        - |        - |        - |          - |
|             **Allocate** |     **1000000** |  **58,041.89 ns** | **1,141.891 ns** | **2,306.675 ns** |  **59,095.29 ns** |   **11** | **249.9390** | **249.9390** | **249.9390** |  **1000024 B** |
| RentAndReturn_Shared |     1000000 |      76.07 ns |     0.750 ns |     0.665 ns |      76.24 ns |    3 |        - |        - |        - |          - |
|  RentAndReturn_Aware |     1000000 |      90.53 ns |     0.626 ns |     0.585 ns |      90.48 ns |    7 |        - |        - |        - |          - |
|             **Allocate** |    **10000000** | **411,724.08 ns** | **2,776.060 ns** | **2,318.136 ns** | **412,024.32 ns** |   **13** | **134.7656** | **134.7656** | **134.7656** | **10000021 B** |
| RentAndReturn_Shared |    10000000 |  97,363.65 ns | 1,945.080 ns | 3,700.716 ns |  97,904.78 ns |   12 | 109.2529 | 109.2529 | 109.2529 | 10000017 B |
|  RentAndReturn_Aware |    10000000 |      86.74 ns |     0.394 ns |     0.369 ns |      86.76 ns |    6 |        - |        - |        - |          - |
