using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePatternsTest
{
    public class FirstOrDefaultVsFind
    {
        private List<int> list;

        public FirstOrDefaultVsFind()
        {
            list = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        }

        [Fact]
        public void FirstOrDefault()
        {
            var result = list.FirstOrDefault(x => x > 5);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Find()
        {
            var result = list.Find(x => x > 5);
            Assert.Equal(6, result);
        }
    }
}
