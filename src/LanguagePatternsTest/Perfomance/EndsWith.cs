namespace LanguagePatternsTest.Perfomance;

public class EndsWith
{
    private string testString;

    public EndsWith()
    {
        testString = "This is a test string";
    }

    [Fact]
    public void EndsWithString()
    {
        var result = testString.EndsWith("g");
        Assert.True(result);
    }

    [Fact]
    public void EndsWithChar()
    {
        var result = testString.EndsWith('g');
        Assert.True(result);
    }

}