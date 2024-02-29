using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePatternsTest.Performance;

public class AnyVsContains
{
    private readonly int[] _numbers;

    public AnyVsContains()
    {
        _numbers = new int[100];
        for (int i = 1; i <= 100; i++)
        {
            _numbers[i-1] = i;
        }
    }

    [Fact]
    public void Any()
    {
        bool any5 = _numbers.Any(n => n == 5);
        Assert.True(any5);
    }

    [Fact]
    public void Contains()
    {
        bool contains5 = _numbers.Contains(5);
        Assert.True(contains5);
    }
}
