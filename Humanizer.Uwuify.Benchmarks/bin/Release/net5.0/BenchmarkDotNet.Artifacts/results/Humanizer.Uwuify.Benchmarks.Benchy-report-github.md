``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1110 (21H1/May2021Update)
AMD Ryzen 7 2700, 1 CPU, 16 logical and 8 physical cores
.NET SDK=5.0.100
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
| Method |      Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |----------:|----------:|----------:|-------:|------:|------:|----------:|
|  Test1 |  6.604 μs | 0.1122 μs | 0.1644 μs | 1.6937 |     - |     - |      7 KB |
|  Test2 | 23.161 μs | 0.2285 μs | 0.2025 μs | 5.0659 |     - |     - |     21 KB |
|  Test3 | 29.999 μs | 0.4261 μs | 0.3986 μs | 6.4087 |     - |     - |     26 KB |
