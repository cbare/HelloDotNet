using System.Text;

namespace Hello;

public class NothingUsefulDoer
{
    private int _n;

    public NothingUsefulDoer(int n)
    {
        _n = n;
    }
    public string DoNothingUseful(string x)
    {
        var result = new StringBuilder(x.Length + 1 + 4*_n)
            .Append(x)
            .Append(" ")
            .Insert(0, "==> ", _n)
            .ToString();
        return result.ToString();
    }
}
