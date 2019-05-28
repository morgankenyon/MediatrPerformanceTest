``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.300
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|      Method |   N |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |
|------------ |---- |---------:|---------:|---------:|---------:|------:|--------:|
| TestRegular | 100 | 778.3 ms | 15.51 ms | 40.05 ms | 774.8 ms |  1.00 |    0.00 |
| TestMediatr | 100 | 806.1 ms | 16.04 ms | 41.13 ms | 820.3 ms |  1.04 |    0.07 |
