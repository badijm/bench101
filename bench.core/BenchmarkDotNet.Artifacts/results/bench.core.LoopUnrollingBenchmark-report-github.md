``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.17763.1098 (1809/October2018Update/Redstone5)
Intel Xeon CPU E3-1505M v6 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|       Method | size |   array1D |        Mean |     Error |    StdDev | Ratio | Rank |
|------------- |----- |---------- |------------:|----------:|----------:|------:|-----:|
|   **NormalLoop** |  **100** | **Double[0]** |    **92.71 ns** |  **1.575 ns** |  **1.875 ns** |  **1.00** |    **2** |
| UnrolledLoop |  100 | Double[0] |    45.58 ns |  0.688 ns |  0.574 ns |  0.49 |    1 |
|              |      |           |             |           |           |       |      |
|   **NormalLoop** | **1000** | **Double[0]** | **1,111.97 ns** | **19.046 ns** | **16.884 ns** |  **1.00** |    **2** |
| UnrolledLoop | 1000 | Double[0] |   474.22 ns |  9.303 ns | 11.765 ns |  0.43 |    1 |
