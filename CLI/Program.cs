using Microsoft.Extensions.Logging;
using Hello;

const String VERSION = "0.0.1";


using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .AddFilter("Microsoft", LogLevel.Warning)
        .AddFilter("System", LogLevel.Warning)
        .AddFilter("Program", LogLevel.Debug)
        .AddConsole();
});


var logger = loggerFactory.CreateLogger("HelloDotNet");
logger.LogInformation("Begin HelloDotNet!");

Console.WriteLine("HelloDotNet {0}", VERSION);

var nothingUsefulDoer = new NothingUsefulDoer(3);
Console.WriteLine(nothingUsefulDoer.DoNothingUseful("Hello, World!"));

logger.LogInformation("Done HelloDotNet!");
