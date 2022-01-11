using Hello;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hello.Tests;

[TestClass]
public class TestNothingUsefulDoer
{
    private ILogger _logger;

    public TestNothingUsefulDoer()
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter("Microsoft", LogLevel.Warning)
                .AddFilter("System", LogLevel.Warning)
                .AddFilter("Program", LogLevel.Debug)
                .AddConsole();
        });

        _logger = loggerFactory.CreateLogger("HelloDotNet");
    }

    [TestMethod]
    public void TestDoNothingUseful()
    {
        var nothingUsefulDoer = new NothingUsefulDoer(_logger);
        Console.WriteLine(nothingUsefulDoer.DoNothingUseful("Hello, World!", 3));
    }
}