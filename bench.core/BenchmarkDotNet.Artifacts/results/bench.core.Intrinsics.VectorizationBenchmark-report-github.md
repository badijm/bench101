``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.1098 (1809/October2018Update/Redstone5)
Intel Xeon CPU E3-1505M v6 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]    : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  RyuJitX64 : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT

Job=RyuJitX64  Jit=RyuJit  Platform=X64  

```
|    Method |     Mean |     Error |    StdDev | Rank |
|---------- |---------:|----------:|----------:|-----:|
| CustomMul | 3.288 ns | 0.0982 ns | 0.0965 ns |    3 |
| SystemMul | 1.656 ns | 0.0664 ns | 0.0863 ns |    1 |
| CustomAdd | 3.104 ns | 0.0853 ns | 0.0712 ns |    2 |
| SystemAdd | 1.626 ns | 0.0970 ns | 0.1078 ns |    1 |
