//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input: | output:
//Hi!	 | \u0048\u0069\u0021

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Please enter string to convert:");
        string input = Console.ReadLine().Trim();
        StringBuilder result = new StringBuilder();

        foreach (char symbol in input)
        {
            result.Append("\\u");
            result.Append(((int)symbol).ToString("x4"));
        }

        Console.WriteLine("\nConverted string:");
        Console.WriteLine(result.ToString());
    }
}
