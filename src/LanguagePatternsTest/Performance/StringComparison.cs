namespace LanguagePatternsTest.Performance;

public class StringComparison
{
    private readonly string firstString;
    private readonly string secondString;

    public StringComparison()
    {
        firstString = "David";
        secondString = "david";
    }

    [Fact]
    public void WithToUpper()
    {
        var result = string.Equals(firstString.ToUpper(), secondString.ToUpper());
        Assert.True(result);
    }

    [Fact]
    public void WithEquals()
    {
        var result = string.Equals(firstString, secondString, System.StringComparison.OrdinalIgnoreCase);
        Assert.True(result);
    }
}
