// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using Google.Apis.Translate.v2;

Console.WriteLine("Hello, World!");

var regex = @"(\.*\)";
using var file = new StreamReader("/Users/dbotta/dbrepos/tutorial/Tutorial/Basics/Program.cs");

var output = new List<string>();
while (!file.EndOfStream)
{
    var line = await file.ReadLineAsync();
    try
    {
        if (line is null)
            continue;

        var match = Regex.Match(regex, line);
        if (match.Success)
        {
            https://www.google.com/async/translate?vet=12ahUKEwj9m4np24D7AhW9XvEDHSr1CJEQqDh6BAgJECw..i&ei=s6JaY732Kb29xc8PquqjiAk&yv=3&cs=1
            var translation = client.GetAsync(" ")
            line = line.Replace(match.Value, translation);
        }
    }
    finally
    {
        output.Add(line ?? Environment.NewLine);
    }
}