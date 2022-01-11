# Hello DotNet

A test project to learn the basics of C# programming, very reluctantly.


## Commands

### Run CLI

```sh
dotnet run --project CLI/.
```

### Run Tests

```sh
dotnet test
```

Or to see console output do this:

```sh
dotnet test -l "console;verbosity=detailed"
```

...see CharlieDigital's comment at the bottom of this issue: [Console.WriteLine calls during dotnet test are not emitted to the console on Windows][7]


## Sources of information

- Microsoft's [C# documentation][1]
- [dotnet command][6] docs
- [Unit testing best practices with .NET][5]
- [Moq library docs][8]
- [Unit Testing with ILogger][9]
- [David Fowler][2] has collected some good information
- David Fowler [Dot Net project layout][3]
- [Getting Started with xUnit.net][4]


[1]: https://docs.microsoft.com/en-us/dotnet/csharp/
[2]: https://github.com/davidfowl
[3]: https://gist.github.com/davidfowl/ed7564297c61fe9ab814
[4]: https://xunit.net/docs/getting-started/netfx/cmdline
[5]: https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
[6]: https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet
[7]: https://github.com/Microsoft/vstest/issues/799
[8]: https://github.com/moq/moq4
[9]: https://github.com/dotnet-labs/UnitTestingWithILogger
