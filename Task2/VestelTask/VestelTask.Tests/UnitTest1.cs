using Xunit;

namespace VestelTask.Tests
{
    public class UnitTest1
    {
        public class TextReverserTests
        {
            [Theory]
            [InlineData("hello world", "dlrow olleh")]
            [InlineData("", "")]
            [InlineData(null, "")]
            public void Reverse_ReturnsExpected(string input, string expected)
            {
                var reverser = new TextReverser();
                var result = reverser.Reverse(input);
                Assert.Equal(expected, result);
            }
        }
    }
}


