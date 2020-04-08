``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.1098 (1809/October2018Update/Redstone5)
Intel Xeon CPU E3-1505M v6 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|        Method |  size |         array2D |          Mean |        Error |       StdDev | Ratio | RatioSD | Rank |
|-------------- |------ |---------------- |--------------:|-------------:|-------------:|------:|--------:|-----:|
|    **NormalLoop** |   **100** | **System.Int32[,]** |      **54.23 us** |     **0.420 us** |     **0.351 us** |  **1.00** |    **0.00** |    **2** |
| UnrolledLoop4 |   100 | System.Int32[,] |      13.41 us |     0.139 us |     0.130 us |  0.25 |    0.00 |    1 |
| UnrolledLoop8 |   100 | System.Int32[,] |            NA |           NA |           NA |     ? |       ? |    ? |
|               |       |                 |               |              |              |       |         |      |
|    **NormalLoop** |  **1000** | **System.Int32[,]** |   **5,374.52 us** |    **98.284 us** |    **87.126 us** |  **1.00** |    **0.00** |    **3** |
| UnrolledLoop4 |  1000 | System.Int32[,] |   1,343.01 us |    12.046 us |    11.268 us |  0.25 |    0.00 |    2 |
| UnrolledLoop8 |  1000 | System.Int32[,] |     679.16 us |     7.659 us |     6.790 us |  0.13 |    0.00 |    1 |
|               |       |                 |               |              |              |       |         |      |
|    **NormalLoop** | **10000** | **System.Int32[,]** | **534,066.44 us** | **3,542.241 us** | **3,140.105 us** |  **1.00** |    **0.00** |    **3** |
| UnrolledLoop4 | 10000 | System.Int32[,] | 135,192.95 us | 2,514.682 us | 2,229.200 us |  0.25 |    0.01 |    2 |
| UnrolledLoop8 | 10000 | System.Int32[,] |  68,044.42 us |   577.471 us |   540.167 us |  0.13 |    0.00 |    1 |

Benchmarks with issues:
  LoopUnrollingBenchmark.UnrolledLoop8: DefaultJob [size=100, array2D=System.Int32[,]]
