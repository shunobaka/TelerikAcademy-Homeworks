//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] upperChars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        string output = "";

        foreach (char next in input)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (next == chars[i])
                {
                    output += i + ", ";
                }
            }

            for (int i = 0; i < upperChars.Length; i++)
            {
                if (next == upperChars[i])
                {
                    output += i + ", ";
                }
            }
        }
        output = output.TrimEnd();
        output = output.TrimEnd(',');
        Console.WriteLine(output);
    }
}
