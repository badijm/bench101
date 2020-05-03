``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.17763.1098 (1809/October2018Update/Redstone5)
Intel Xeon CPU E3-1505M v6 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]    : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  RyuJitX64 : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT

Job=RyuJitX64  Jit=RyuJit  Platform=X64  

```
|    Method |     Mean |     Error |    StdDev | Rank | Code Size |
|---------- |---------:|----------:|----------:|-----:|----------:|
| CustomMul | 2.999 ns | 0.0227 ns | 0.0190 ns |    3 |     119 B |
| SystemMul | 1.542 ns | 0.0415 ns | 0.0388 ns |    1 |      23 B |
| CustomAdd | 2.924 ns | 0.0227 ns | 0.0201 ns |    2 |     119 B |
| SystemAdd | 1.516 ns | 0.0164 ns | 0.0145 ns |    1 |      23 B |
