using Microsoft.Extensions.Logging;
using Hello;

const String VERSION = "0.0.1";


var loggerFactory = LoggerFactory.Create(builder =>
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

var nothingUsefulDoer = new NothingUsefulDoer(logger);
Console.WriteLine(nothingUsefulDoer.DoNothingUseful("Hello, World!", 3));

logger.LogInformation("Done HelloDotNet!");
