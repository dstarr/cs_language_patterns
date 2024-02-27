using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePatterns
{
    public class EndsWithPerformance
    {
        public bool EndsWithString(string lastChar)
        {
            const string testString = "This is a test string";

            return testString.EndsWith(lastChar);
        }
    }
}
