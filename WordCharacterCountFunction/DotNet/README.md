# Word Character Count Function Challenge

## Description

Write a program that parses a sentence and replaces each word with the following: first letter, number of distinct characters between first and last character, and last letter. Spaces or non-alphabetic characters separate words, and the program should maintain the separators' original form and location in the answer.

## Examples

| Input                           | Output                        |
|---------------------------------|-------------------------------|
| It was many and many a year ago | I0t w1s m2y a1d m2y a y2r a1o |
| Copyright,Microsoft:Corporation | C7t,M6t:C6n                   |

## User Interface Expectations

- **Input:** Command Line Interface: One should be able to pass the argument (input) on the command line
- **Output:** Should print the output on the command line

## Rules

- Use the main function arguments.
- The function should not be static or main.
- The function should not use hardcoded values.
- The function must be reusable.
- Include test cases.
- Document your code.
- Code should have accuracy, efficiency, solution completeness, and hygiene.
- Include the results of your test run with your test data, along with the source code in your solution.

## Development

### Build and Test

```shell
cd {folder with WordCharacterCountFunction.sln}
dotnet build
dotnet test
```

### Run

```shell
cd {folder with WordCharacterCountFunction.UI.Console.csproj}
dotnet run "It was many and many a year ago"
```

## Run Tests with File

```bash
$ ./Scripts/Test_WordCharacterCountFunction.sh {path to WordCharacterCountFunction.UI.Console.csproj} {path to test file}
```
```powershell
PS> .\Scripts\Test_WordCharacterCountFunction.ps1 {path to WordCharacterCountFunction.UI.Console.csproj} {path to test file}
```

### Example of Test File and Results

- [Test-Data-20231207.txt](./Tests/Test-Data-20231207.txt)
- [Test-Data-20231207-Results.txt](./Tests/Test-Data-20231207-Results.txt)