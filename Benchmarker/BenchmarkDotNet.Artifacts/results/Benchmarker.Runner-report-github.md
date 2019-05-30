``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.300
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|        Method |     N |        Mean |      Error |     StdDev |
|-------------- |------ |------------:|-----------:|-----------:|
|    **TestScoped** |   **300** |    **99.55 ms** |   **1.836 ms** |   **1.533 ms** |
| TestTransient |   300 |   102.96 ms |   2.486 ms |   2.204 ms |
| TestSingleton |   300 |   100.75 ms |   1.896 ms |   2.029 ms |
|   TestMediatr |   300 |   103.31 ms |   1.968 ms |   1.841 ms |
|    **TestScoped** |  **1500** |   **503.22 ms** |   **9.832 ms** |  **10.096 ms** |
| TestTransient |  1500 |   510.82 ms |  20.271 ms |  22.531 ms |
| TestSingleton |  1500 |   529.53 ms |  11.154 ms |  21.221 ms |
|   TestMediatr |  1500 |   530.10 ms |  10.070 ms |  11.988 ms |
|    **TestScoped** | **20000** | **6,790.08 ms** | **117.529 ms** |  **98.142 ms** |
| TestTransient | 20000 | 6,829.87 ms | 130.331 ms | 144.863 ms |
| TestSingleton | 20000 | 6,876.44 ms | 134.226 ms | 235.086 ms |
|   TestMediatr | 20000 | 6,932.56 ms | 135.209 ms | 189.544 ms |
