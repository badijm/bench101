``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.16299.125 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3517U CPU 1.90GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2338437 Hz, Resolution=427.6361 ns, Timer=TSC
.NET Core SDK=5.0.100-preview.2.20176.6
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|          Method |  size |         array2D |            Mean |         Error |        StdDev | Ratio | RatioSD | Rank |
|---------------- |------ |---------------- |----------------:|--------------:|--------------:|------:|--------:|-----:|
|    **RowTraversal** |   **100** | **System.Int32[,]** |        **21.86 us** |      **0.418 us** |      **0.327 us** |  **1.00** |    **0.00** |    **1** |
| ColumnTraversal |   100 | System.Int32[,] |        22.64 us |      0.479 us |      1.042 us |  1.03 |    0.04 |    1 |
|                 |       |                 |                 |               |               |       |         |      |
|    **RowTraversal** |  **1000** | **System.Int32[,]** |     **2,162.60 us** |     **26.876 us** |     **20.983 us** |  **1.00** |    **0.00** |    **1** |
| ColumnTraversal |  1000 | System.Int32[,] |     8,214.22 us |    161.680 us |    179.707 us |  3.79 |    0.08 |    2 |
|                 |       |                 |                 |               |               |       |         |      |
|    **RowTraversal** | **10000** | **System.Int32[,]** |   **214,424.87 us** |  **4,196.625 us** |  **7,126.188 us** |  **1.00** |    **0.00** |    **1** |
| ColumnTraversal | 10000 | System.Int32[,] | 1,248,867.51 us | 24,438.602 us | 28,143.531 us |  5.82 |    0.24 |    2 |
