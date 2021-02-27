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

        [Theory]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData(null, true)]
        [InlineData("lorem ipsum dolor", false)]
        public void InNullOrWhiteSpace_Valid(string input, bool expected)
            => Assert.Equal(expected, input.IsNullOrWhiteSpace());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem     ipsum dolor    ", "lorem ipsum dolor")]
        [InlineData("  lorem     ipsum   dolor", "lorem ipsum dolor")]
        public void RemoveWideSpaces_Valid(string input, string expected)
            => Assert.Equal(expected, input.RemoveWideSpaces());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem      ipsum dolor ", "lorem ipsum dolor")]
        [InlineData("       lorem       ipsum       dolor", "lorem ipsum dolor")]
        public void ReplaceTabsWithSpaces_Valid(string input, string expected)
            => Assert.Equal(expected, input.ReplaceTabsWithSpaces());

        [Theory]
        [InlineData("lorem      ipsum   dolor", "lorem      ipsum   dolor")]
        [InlineData("   lorem      ipsum   dolor", "abcd lorem      ipsum   dolor")]
        public void ReplaceTabsWithSpaces_InValid(string input, string expected)
            => Assert.NotEqual(expected, input.ReplaceTabsWithSpaces());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem\nipsum dolor", "lorem ipsum dolor")]
        [InlineData("lorem\nipsum dolor\n", "lorem ipsum dolor")]
        public void NewLinesToWhiteSpacess_Valid(string input, string expected)
            => Assert.Equal(expected, input.NewLinesToWhiteSpaces());


    }
}
