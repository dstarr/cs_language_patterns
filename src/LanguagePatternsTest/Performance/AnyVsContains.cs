namespace LanguagePatternsTest.Performance;

public class AnyVsContains
{
    private readonly List<int> _numbers = new();

    public AnyVsContains()
    {
        for (var i = 1; i <= 1000; i++)
        {
            _numbers.Add(i);
        }
    }

    [Fact]
    public void Any()
    {
        var any50 = _numbers.Any(n => n == 50);
        Assert.True(any50);
    }

    [Fact]
    public void Contains()
    {
        var contains50 = _numbers.Contains(50);
        Assert.True(contains50);
    }
}
