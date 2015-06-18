//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Text;
using System.Collections.Generic;

class OrderWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter words separated by space:");
        string inputWords = Console.ReadLine();
        string[] words = inputWords.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        Console.WriteLine("\nThe words ordered alphabetically:\n");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
