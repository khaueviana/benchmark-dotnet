``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), ProcessorCount=4
Frequency=2835938 Hz, Resolution=352.6170 ns, Timer=TSC
.NET Core SDK=1.0.4
  [Host]     : .NET Core 1.1.2 (Framework 4.6.25211.01), 64bit RyuJIT DEBUG  [AttachedDebugger]
  DefaultJob : .NET Core 1.1.2 (Framework 4.6.25211.01), 64bit RyuJIT


```
 |                Method |     Mean |    Error |   StdDev |
 |---------------------- |---------:|---------:|---------:|
 |   GenerateDataWithFor | 351.6 ms | 4.391 ms | 3.667 ms |
 | GenerateDataWithWhile | 366.1 ms | 7.050 ms | 8.393 ms |
