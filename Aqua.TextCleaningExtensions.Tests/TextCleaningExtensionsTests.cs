using Xunit;

namespace Aqua.TextCleaningExtensions.Tests
{
    public class TextCleaningExtensionsTests
    {
        [Theory]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData(null, true)]
        [InlineData("lorem ipsum dolor", false)]
        public void InNullOrEmpty_Valid(string input, bool expected)
            => Assert.Equal(expected, input.IsNullOrEmpty());
    }
}
