using Hello;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Hello.Tests;

[TestClass]
public class TestNothingUsefulDoer
{
    [TestMethod]
    public void TestDoNothingUseful()
    {
        var loggerMock = new Mock<ILogger>();

        var nothingUsefulDoer = new NothingUsefulDoer(loggerMock.Object);
        var result = nothingUsefulDoer.DoNothingUseful("Hello, World!", 3);
        Assert.AreEqual(result, "==> ==> ==> Hello, World!");
        Console.WriteLine(result);

        // apparently, this is the horrific way to verify that you wrote log lines.
        // see: https://stackoverflow.com/a/68720345/199166
        loggerMock.Verify(
            x => x.Log(
                It.Is<LogLevel>(l => l == LogLevel.Information),
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((v, t) => v.ToString()=="Create NothingUsefulDoer"),
                It.IsAny<Exception>(),
                It.Is<Func<It.IsAnyType, Exception?, string>>((v, t) => true)),
            Times.AtLeastOnce);

        loggerMock.Verify(
            x => x.Log(
                It.Is<LogLevel>(l => l == LogLevel.Information),
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((v, t) => v.ToString()=="Invoke DoNothingUseful"),
                It.IsAny<Exception>(),
                It.Is<Func<It.IsAnyType, Exception?, string>>((v, t) => true)),
            Times.AtLeastOnce);
    }
}
