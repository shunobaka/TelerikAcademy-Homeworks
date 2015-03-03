//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

//input                 	| output
//aaaaabbbbbcdddeeeedssaa	| abcdedsa

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Please enter sequence of characters:");
        StringBuilder input = new StringBuilder();
        StringBuilder output = new StringBuilder();
        input.Append(Console.ReadLine().Trim().Replace(" ", string.Empty));

        int start = 0;
        char currentChar = new char();
        char sequenceChar = input[0];

        for (int index = 0; index < input.Length; index++)
        {
            currentChar = input[index];
            if (currentChar != sequenceChar)
            {
                output.Append(sequenceChar);
                sequenceChar = currentChar;
                start = index;
            }
            if (index == input.Length - 1)
            {
                output.Append(sequenceChar);
            }
        }
        Console.WriteLine("\nOutput sequence:");
        Console.WriteLine(output.ToString());
    }
}
