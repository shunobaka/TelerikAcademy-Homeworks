//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        var allChars = new String(input.ToLower().Where(Char.IsLetter).ToArray());
        List<char> chars = new List<char>();

        foreach (char currentChar in allChars)
        {
            if (chars.IndexOf(currentChar) == (-1))
            {
                chars.Add(currentChar);
            }
        }

        Console.WriteLine("\nList of characters:");

        foreach (char currentChar in chars)
        {
            int counter = 0;
            foreach (char charInSentense in allChars)
            {
                if (currentChar == charInSentense)
                {
                    counter++;
                }
            }
            if (counter == 1)
            {
                Console.WriteLine("{0} - {1} time", currentChar, counter);
            }
            else
            {
                Console.WriteLine("{0} - {1} times", currentChar, counter);
            }
        }
    }
}
