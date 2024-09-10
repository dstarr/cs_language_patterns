using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePatternsTest.Sugar;

public class TakeWhileMethod
{
    private readonly List<string> _list;

    public TakeWhileMethod()
    {
        _list = new List<string>
        {
            "David",
            "Dani",
            "Don",
            "Alberto",
            "Benito",
            "Carlos",
            "Dragon",
            "Eva",
            "Felipe",
            "Gustavo",
            "Hugo",
            "Ivan",
            "Jorge",
            "Kevin",
            "Luis",
            "Miguel",
            "Nestor",
            "Oscar",
        };
    }

    [Fact]
    public void WhereMethodTest()
    {
        Assert.Equal(18, _list.Count);

        var result = _list
            .Where(x => x.StartsWith('D'))
            .ToList();
        
        Assert.Equal(4, result.Count);
        Assert.Equal("Don", result[2]);
    }

    [Fact]
    public void TakeWhileMethodTest()
    {
        Assert.Equal(18, _list.Count);

        var result = _list
            .TakeWhile(x => x.StartsWith('D'))
            .ToList();

        Assert.Equal(3, result.Count);
        Assert.Equal("Don", result[2]);
    }

}
