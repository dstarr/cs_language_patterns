using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePatternsTest.Sugar;

public class SpreadOperator
{
    readonly int[] _first = { 1 ,2, 3 };
    readonly int[] _second = { 4, 5, 6 };
    readonly int[] _third = { 7, 8, 9 };
    
    [Fact]
    public void JoinListsWithConcat()
    {
        int[] singleArray = _first.Concat(_second).Concat(_third).ToArray();
        Assert.Equal(9, singleArray.Length);
    }
}
