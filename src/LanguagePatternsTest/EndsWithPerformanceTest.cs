using LanguagePatterns;

namespace LanguagePatternsTest
{
    public class EndsWithPerformanceTest
    {
        [Fact]
        public void EndsWithStringTest()
        {
            var endsWithPerformance = new EndsWithPerformance();
            endsWithPerformance.EndsWithString("g");
        }
    }
}