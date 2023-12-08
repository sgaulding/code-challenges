using FluentAssertions;
using WordCharacterCountFunction.UI.Console;

namespace WordCharacterCountFunction.Tests.Unit;

public class WordCharacterCountParserTests
{

    [Theory]
    [InlineData("", "")]
    [InlineData(" ", " ")]
    [InlineData(" . ", " . ")]
    [InlineData("Hello", "H2o")]
    [InlineData("HelLo", "H2o")]
    [InlineData("Hello,", "H2o,")]
    [InlineData(",Hello,", ",H2o,")]
    [InlineData(",Hello", ",H2o")]
    [InlineData("Hello, World!", "H2o, W3d!")]
    [InlineData("The quick brown fox jumped over the lazy dog.", "T1e q3k b3n f1x j4d o2r t1e l2y d1g.")]
    [InlineData("The cow jumped over the moon.", "T1e c1w j4d o2r t1e m1n.")]
    [InlineData("La vaca saltó sobre la luna.", "L0a v2a s3ó s3e l0a l2a.")]
    [InlineData("It was many and many a year ago", "I0t w1s m2y a1d m2y a y2r a1o")]
    [InlineData("Copyright,Microsoft:Corporation", "C7t,M6t:C6n")]
    [InlineData(",Copyright,Microsoft:Corporation,", ",C7t,M6t:C6n,")]
    public void ReplaceMiddleOfWordsWithDistinctCharacterCount_ShouldReturnExpected_WhenProvidedInput(
        string input,
        string expected)
    {
        var sut = new WordCharacterCountParser();
        var actual = sut.Parse(input);
        actual.Should().Be(expected);
    }
}