# TextNumbers - Library For Converting Numbers To Words

:gb: English | [:azerbaijan: Azərbaycan dilində oxu](README.AZ.md)

---
[![NuGet](https://img.shields.io/nuget/v/TextNumbers.svg)](https://www.nuget.org/packages/TextNumbers/)  [![Build](https://github.com/Ork-Khan/TextNumbers/actions/workflows/build-and-test.yml/badge.svg) ](https://github.com/Ork-Khan/TextNumbers/actions) [![License: MIT](https://img.shields.io/github/license/Ork-Khan/TextNumbers.svg)](https://github.com/Ork-Khan/TextNumbers/blob/main/LICENSE) [![Target Frameworks](https://img.shields.io/badge/.NET-5.0--10.0%20%7C%20netstandard2.1-512BD4)](https://www.nuget.org/packages/TextNumbers/)

---
`TextNumbers` is a .Net / C# library for converting rational numbers (integers and fractions) to their written form in Azerbaijani language.

---
## Requirements:
`net5.0`, `net6.0`, `net7.0`, `net8.0`, `net9.0`, `net10.0` or frameworks that support `netstandard2.1`. 
## Installation:

You can install latest version  of the library via `Nuget` in terminal:
`dotnet add package TextNumbers
## Usage:

```C#
using TextNumbers;

//integer or decimal
string resultInt = NumberConvert.Convert(123); 
Console.WriteLine(resultInt); //yüz yirmi üç
string resultDecimal = NumberConvert.Convert(-3012.2001); 
Console.WriteLine(resultDecimal); //mənfi üç min on iki tam on mində iki min bir
```
## Features
- conversion of `int` or `decimal` types
- conversion of negative numbers
- conversion of floating point numbers