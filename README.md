[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg?style=flat-square&logo=Apache)](LICENSE)

# DataJuggler.Excelerate.Office

DataJuggler.Excelerate.Office is an independent build of [NPOI](https://github.com/nissl-lab/npoi), the .NET port of [Apache POI](https://poi.apache.org/). It reads and writes Excel files (.xlsx and the older .xls) without needing Office or COM.

It is the Office engine behind [DataJuggler.Excelerate](https://github.com/DataJuggler/DataJuggler.Excelerate).

## Why this fork exists

Starting with version 2.8.0, the official NPOI NuGet packages ship with an Open Source Maintenance Fee (OSMF) EULA, which requires a monthly fee from anyone who uses the binaries to make money and earns more than $10,000 a year.

The NPOI source code is still licensed under Apache 2.0, and that license lets anyone build, change and redistribute it. This package is built from that source **without the OSMF EULA**, so DataJuggler.Excelerate and anything else that uses this package can be used by anyone, commercial or not, under the plain Apache 2.0 license.

## Credit

Nearly all of the code in this repository is the work of **Tony Qu and the NPOI contributors**. See [Contributors.md](Contributors.md) for the full list. If NPOI helps your business, consider supporting the original project through [GitHub Sponsors](https://github.com/sponsors/tonyqus).

This fork is not affiliated with or endorsed by the NPOI project or Nissl LLC.

## Forked from

| | |
|---|---|
| Upstream | [nissl-lab/npoi](https://github.com/nissl-lab/npoi) |
| Version | 2.8.1 |

## Changes from upstream

- Removed the OSMF EULA (`OSMFEULA.txt`) and the MSBuild target (`NPOI.targets`) that required accepting it.
- Package license set to `Apache-2.0`.
- Assemblies renamed so they can't collide with the official NPOI packages:

  | NPOI | DataJuggler.Excelerate.Office |
  |---|---|
  | NPOI.Core.dll | DataJuggler.Excelerate.Office.Core.dll |
  | NPOI.OOXML.dll | DataJuggler.Excelerate.Office.OOXML.dll |
  | NPOI.OpenXml4Net.dll | DataJuggler.Excelerate.Office.OpenXml4Net.dll |
  | NPOI.OpenXmlFormats.dll | DataJuggler.Excelerate.Office.OpenXmlFormats.dll |

- Assemblies are strong-name signed with a DataJuggler key instead of the NPOI key.
- Excel only: removed Word (.docx, .doc) and PowerPoint (.pptx, .ppt) support, plus NPOI's tests, benchmarks, tools and build scripts.
- Namespaces renamed from `NPOI.*` to `DataJuggler.Excelerate.Office.*`, so this package and the official `NPOI` package can be used in the same project without conflicts.

To move existing NPOI code over, replace `NPOI.` with `DataJuggler.Excelerate.Office.` in your `using` statements. For example, `NPOI.XSSF.UserModel` becomes `DataJuggler.Excelerate.Office.XSSF.UserModel`. Class names are unchanged.

## Getting started

```
dotnet add package DataJuggler.Excelerate.Office
```

```csharp
using DataJuggler.Excelerate.Office.SS.UserModel;
using DataJuggler.Excelerate.Office.XSSF.UserModel;
using System.IO;

IWorkbook workbook = new XSSFWorkbook();
ISheet sheet = workbook.CreateSheet("Sheet1");
sheet.CreateRow(0).CreateCell(0).SetCellValue("Hello World");

using FileStream output = File.Create("HelloWorld.xlsx");
workbook.Write(output);
```

NPOI's documentation applies to this package once you swap the namespace:

- [Getting Started with NPOI](https://github.com/nissl-lab/npoi/wiki/Getting-Started-with-NPOI)
- [How to use NPOI on Linux](https://github.com/nissl-lab/npoi/wiki/How-to-use-NPOI-on-Linux)
- [NPOI tutorials on YouTube](https://www.youtube.com/@codingwithtonyqus)

## Supported frameworks

- .NET 8 and .NET 10
- .NET Standard 2.1 and 2.0
- .NET Framework 4.7.2 and later

## License

Apache License 2.0. See [LICENSE](LICENSE).
