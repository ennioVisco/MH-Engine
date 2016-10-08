# MH-Engine

## Introduction
The back-end engine of a textual RPG. Inspired by _Mondo Hogwarts_.

## Project Details
The project is being developed in C#, using the new [ASP.NET Core][ba94eb3f].
Even if the technologies chosen are all cross-platform and open source, ***the only*** recommended platform for the development will be [Visual Studio 2015][36f0ea51].

## Software Requirements
- [Moq - Alpha][1fed25ca]
- [Microsoft - CodeCoverage][a3ea6a6b]

## Contributions Guidelines
To be sure that a minimum quality standard is granted throughout the codebase, some basic rules should be followed for every submission to the project.

1. Public methods must be clearly named and documented.
2. Proper testing must be done in every situation it should be added (see [Testing & Mocking](#testing)).
3. Commits must have a proper description of the changes.

For an extensive description of best practices and guidelines in C# and ASP.NET, refer to the [Engineering Guidelines][6c91f304] of ASP.NET Core.

## <a name="testing"></a> Testing & Mocking
The used testing framework is the .NET Core default, which is based on xunit. A quick guide on how to use xunit together with .NET Core is available [here][ffdda5fb].

The used mocking framework is Moq. Some examples on how to use it are available in the Tests project source code.

To show the code coverage of the unit tests, Microsoft CodeCoverage is being used.

## Copyright
License: GPL 3.0

For commercial purposes please refer directly to the admins of the repository.

## Authors
[TODO]

[//]: # (References)

[ba94eb3f]: http://docs.asp.net "ASP.NET Documentation"    [36f0ea51]: https://www.visualstudio.com/en-us/products/vs-2015-product-editions.aspx "Download Visual Studio 2015 Now!"
[1fed25ca]: https://www.nuget.org/packages/Moq/4.6.38-alpha "Moq"
[6c91f304]: https://github.com/aspnet/Home/wiki/Engineering-guidelines "Engineering Guidelines"
[ffdda5fb]: https://github.com/dotnet/core-docs/tree/master/samples/core/getting-started/unit-testing-using-dotnet-test "Using .NET Testing"
[a3ea6a6b]: https://www.nuget.org/packages/Microsoft.CodeCoverage/ "Microsoft - CodeCoverage"
