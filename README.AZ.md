# TextNumbers - Ədədləri Sözlə Yazılış Halına Çevirən Kitabxana

[:gb: Read in English](README.md) | :azerbaijan: Azərbaycan dili

---
[![NuGet](https://img.shields.io/nuget/v/TextNumbers.svg)](https://www.nuget.org/packages/TextNumbers/)  [![Build](https://github.com/Ork-Khan/TextNumbers/actions/workflows/build-and-test.yml/badge.svg) ](https://github.com/Ork-Khan/TextNumbers/actions) [![License: MIT](https://img.shields.io/github/license/Ork-Khan/TextNumbers.svg)](https://github.com/Ork-Khan/TextNumbers/blob/main/LICENSE) [![Target Frameworks](https://img.shields.io/badge/.NET-5.0--10.0%20%7C%20netstandard2.1-512BD4)](https://www.nuget.org/packages/TextNumbers/)

---
`TextNumbers` .Net / C# üçün rasional ədədləri (tam və kəsr ədədlər) Azərbaycan dilində yazılışına çevirən kitabxana.

---
## Tələblər:
`net5.0`, `net6.0`, `net7.0`, `net8.0`, `net9.0`, `net10.0` və ya `netstandard2.1` dəstəkləyən istənilən framework. 
## Quraşdırılması:

Kitabxananın son versiyasını aşağıdakı command ilə `Nuget` vasitəsilə yükləyə bilərsiniz:
`dotnet add package TextNumbers`
## İstifadəsi:

```C#
using TextNumbers;

//integer və ya decimal tipi ilə
string resultInt = NumberConvert.Convert(123); 
Console.WriteLine(resultInt); //yüz yirmi üç
string resultDecimal = NumberConvert.Convert(-3012.2001); 
Console.WriteLine(resultDecimal); //mənfi üç min on iki tam on mində iki min bir
```
## Özəlliklər
- `int` və ya `decimal` tipli ədədlərin çevrilməsi
- mənfi ədədlərin çevrilməsi
- kəsr ədədlərin çevrilməsi