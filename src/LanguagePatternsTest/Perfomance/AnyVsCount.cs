using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePatternsTest.Perfomance;
public class AnyVsCount
{
    private List<string> people;

    public AnyVsCount()
    {
        people = new List<string>()
        {
            "David",
            "John",
            "Peter",
            "Paul",
            "Mary",
            "Jane",
            "Lucy",
            "Mark",
            "Luke",
            "Matthew",
        };
    }

    [Fact]
    public void Any()
    {
        var result = people.Any(p => p == "John");
        Assert.True(result);
    }

    [Fact]
    public void Count()
    {
        var result = people.Count(p => p == "John") > 0;
        Assert.True(result);
    }
}
