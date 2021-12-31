# Uwuify.Humanizer

A library to format strings into the UwU variant.

The class library is made to be the main focus of this repository, with the other projects (ConsoleApp and Benchmarks) being purely supplemental. 

The Console app will be released as well.

## Features

- Studder at random intervals (customizable as of 1.0.2).
- Specific characters replaced with 'w' or "ny".
- Kaomojis replaces some puntuation symbols.

## Status Badges

[![CI/CD](https://github.com/nickmartin1ee7/Uwuify.Humanizer/actions/workflows/CICD.yml/badge.svg)](https://github.com/nickmartin1ee7/Uwuify.Humanizer/actions/workflows/CICD.yml)

## Usage

```cs
using Uwuify.Humanizer

string myString = "Hello World! This is an example usage of the cursed humanizer UwU string formatting extension. I hope you love/hate it as much as I do!".Uwuify();

// myString: "hewwo wowwd-.- t-this is an exampwe u-usage o-of the cuwsed h-humanyizew u-uwu s-stwinyg fowmattinyg extenysiony xD i h-hope you wove/hate i-it as much as i-i d-do *:･ﾟ✧*:･ﾟ✧"
```

## Benchmarks (1.0.5)

* BenchmarkDotNet=v0.13.0, OS=Windows 10.0.22000
* AMD Ryzen 7 2700, 1 CPU, 16 logical and 8 physical cores
* .NET SDK=6.0.101
  * [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  * DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


|            Method |      Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |----------:|----------:|----------:|-------:|------:|------:|----------:|
|  TestDefaultShort |  5.189 us | 0.0872 us | 0.0773 us | 1.6098 |     - |     - |      7 KB |
| TestDefaultMedium | 18.573 us | 0.3381 us | 0.3162 us | 4.9438 |     - |     - |     20 KB |
|   TestDefaultLong | 23.797 us | 0.4530 us | 0.5035 us | 6.1035 |     - |     - |     25 KB |
|   TestCustomShort |  6.111 us | 0.1199 us | 0.1427 us | 1.8005 |     - |     - |      7 KB |
|  TestCustomMedium | 21.531 us | 0.4067 us | 0.4521 us | 5.1575 |     - |     - |     21 KB |
|    TestCustomLong | 26.095 us | 0.4944 us | 0.4625 us | 6.5613 |     - |     - |     27 KB |

## Contribution

- Angius#1586 : Thanks for the pattern matching and Span approach!
- https://github.com/senguyen1011/UwUinator : Thank you for the initial inspiration!
