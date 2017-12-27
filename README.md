# MappersPerformance
Performance test for some mappers
Project to test the performance of some mappers like AutoMapper, using BenchmarkDotNet

## Example:

``` ini

BenchmarkDotNet=v0.10.11, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.125)
Processor=Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), ProcessorCount=4
Frequency=2835938 Hz, Resolution=352.6170 ns, Timer=TSC  .NET Core SDK=2.0.3
[Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT


```
|     Method |       Mean |     Error |    StdDev |        Min |        Max |     Median | Rank |
|----------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-----:|
|     Manual |   9.320 us | 0.0358 us | 0.0279 us |   9.286 us |   9.365 us |   9.316 us |    1 |
| AutoMapper | 146.319 us | 1.3009 us | 1.2168 us | 144.955 us | 148.344 us | 145.859 us |    4 |
|      Agile | 137.244 us | 1.4420 us | 1.2783 us | 135.821 us | 140.158 us | 136.955 us |    3 |
|    Mapster |  66.758 us | 0.6715 us | 0.6281 us |  66.041 us |  67.976 us |  66.464 us |    2 |