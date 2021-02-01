using Xunit;
using LevenshteinDistance;

namespace LevenshteinTests
{
    public class LevenshteinTests
    {

        [Theory]
        [InlineData("kitten", "sitting", 3)]
        [InlineData("saturday", "sunday", 3)]
        [InlineData("apple", "apple", 0)]
        void DistanceTest(string a, string b, int distance)
        {
            int dist = Levenshtein.GetDistance(a, b);

            Assert.Equal(distance, dist);
        }
    }
}
