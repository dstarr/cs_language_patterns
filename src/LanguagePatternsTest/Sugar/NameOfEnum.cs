namespace LanguagePatternsTest.Sugar;

public class NameOfEnum
{
    public enum Colors
    {
        Red,
    }

    [Fact]
    public void EnumToString()
    {
        var name = Colors.Red.ToString();
        Assert.Equal("Red", name);
    }

    [Fact]
    public void EnumNameOf()
    {   
        var name = nameof(Colors.Red);
        Assert.Equal("Red", name);
    }
}
