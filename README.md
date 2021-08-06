# Uwuify.Humanizer

A library to format strings into the UwU variant.

The class library is made to be the main focus of this repository, with the other projects (ConsoleApp and Benchmarks) being purely supplemental. 

## Features

- Studder at random intervals (customizable as of 1.0.2).
- Specific characters replaced with 'w' or "ny".
- Kaomojis replaces some puntuation symbols.

## Status Badges

[![CI](https://github.com/nickmartin1ee7/Uwuify.Humanizer/actions/workflows/CI.yml/badge.svg)](https://github.com/nickmartin1ee7/Uwuify.Humanizer/actions/workflows/CI.yml)
Pull Request verification

[![CD](https://github.com/nickmartin1ee7/Uwuify.Humanizer/actions/workflows/CD.yml/badge.svg)](https://github.com/nickmartin1ee7/Uwuify.Humanizer/actions/workflows/CD.yml)
NuGet Package Updates

## Usage

```cs
using Uwuify.Humanizer

string myString = "Hello World! This is an example usage of the cursed humanizer UwU string formatting extension. I hope you love/hate it as much as I do!".Uwuify();

// myString: "hewwo wowwd-.- t-this is an exampwe u-usage o-of the cuwsed h-humanyizew u-uwu s-stwinyg fowmattinyg extenysiony xD i h-hope you wove/hate i-it as much as i-i d-do *:･ﾟ✧*:･ﾟ✧"
```

## Benchmarks (1.0.2)

* BenchmarkDotNet=v0.13.0, OS=Windows 10
* AMD, 1 CPU, 16 logical and 8 physical cores
* .NET SDK=5.0.100
  * [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  * DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


|            Method |      Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |----------:|----------:|----------:|-------:|------:|------:|----------:|
|  TestDefaultShort |  6.265 us | 0.0892 us | 0.0791 us | 1.6937 |     - |     - |      7 KB |
| TestDefaultMedium | 22.431 us | 0.2268 us | 0.2011 us | 5.0659 |     - |     - |     21 KB |
|   TestDefaultLong | 29.403 us | 0.4430 us | 0.3927 us | 6.4087 |     - |     - |     26 KB |
|   TestCustomShort | 10.067 us | 0.1991 us | 0.2213 us | 2.1973 |     - |     - |      9 KB |
|  TestCustomMedium | 29.079 us | 0.5545 us | 0.5187 us | 5.9509 |     - |     - |     24 KB |
|    TestCustomLong | 37.586 us | 0.6099 us | 0.5093 us | 7.9346 |     - |     - |     33 KB |

## Contribution

- Angius#1586 : Thanks for the pattern matching and Span approach!
- https://github.com/senguyen1011/UwUinator : Thank you for the initial inspiration!
