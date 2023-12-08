using WordCharacterCountFunction.UI.Console;

var wordCharacterCountParser = new WordCharacterCountParser();
foreach (var argument in args)
{
    var output = wordCharacterCountParser.Parse(argument);
    Console.WriteLine(output);
}