using System.Text;

namespace WordCharacterCountFunction.UI.Console;

public class WordCharacterCountParser
{
    /// <summary>
    /// Parses the input string by formatting each word with distinct character count in the middle of the word.
    /// </summary>
    /// <param name="input">The input string to parse.</param>
    /// <returns>The parsed string with each word formatted with distinct character count in the middle.</returns>
    public string Parse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return input;

        var stringBuilder = new StringBuilder();
        var word = string.Empty;
        foreach (var character in input.ToArray())
        {
            if (IsCharacterSeparator(character))
            {
                var formattedWord = FormatWordWithDistinctCharacterCountInMiddleOfWord(word);
                word = string.Empty;
                stringBuilder.Append(formattedWord);
                stringBuilder.Append(character);
                continue;
            }

            word += character;
        }

        var finalReplacedWord = FormatWordWithDistinctCharacterCountInMiddleOfWord(word);
        stringBuilder.Append(finalReplacedWord);
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Formats a word by replacing the middle characters with the count of distinct characters in lowercase.
    /// </summary>
    /// <param name="wordToReplace">The word to be formatted.</param>
    /// <returns>
    /// The formatted word. The middle characters are replaced with the count of distinct characters in lowercase.
    /// If the length of the word is less than or equal to 1, the original word is returned.
    /// </returns>
    private static string FormatWordWithDistinctCharacterCountInMiddleOfWord(string wordToReplace)
    {
        if (wordToReplace.Length <= 1)
            return wordToReplace;

        var firstLetter = wordToReplace[0];
        var lastLetter = wordToReplace[^1];
        var middleOfWord = wordToReplace[1..^1];
        var distinctCharacterCount = middleOfWord.ToLower().Distinct().Count();
        return $"{firstLetter}{distinctCharacterCount}{lastLetter}";
    }

    /// <summary>
    /// Determines if a character is a separator or not.
    /// </summary>
    /// <param name="character">The character to check.</param>
    /// <returns>Returns true if the character is a separator, otherwise false.</returns>
    private static bool IsCharacterSeparator(char character)
    {
        return !char.IsLetter(character);
    }
}