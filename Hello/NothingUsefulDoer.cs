using Microsoft.Extensions.Logging;
using System.Text;

namespace Hello;

public class NothingUsefulDoer
{
    private ILogger _logger;

    public NothingUsefulDoer(ILogger logger)
    {
        _logger = logger;
        _logger.LogInformation("Create NothingUsefulDoer");
    }
    public string DoNothingUseful(string x, int n)
    {
        _logger.LogInformation("Invoke DoNothingUseful");
        var result = new StringBuilder(x.Length + 1 + 4*n)
            .Append(x)
            .Append(" ")
            .Insert(0, "==> ", n)
            .ToString();
        return result.ToString();
    }
}
