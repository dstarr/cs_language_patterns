using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePatternsTest.Sugar;

public class ListInitialization
{
    [Fact]
    public void InitStyle1()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal(5, list.Count);
    }

    [Fact]
    public void InitStyle2()
    {
        List<int> list = [1, 2, 3, 4, 5];
        Assert.Equal(5, list.Count);
    }

    [Fact]
    public void InitStyle3()
    {
        List<int> list = new() { 1, 2, 3, 4, 5 };
        Assert.Equal(5, list.Count);
    }
    
}
