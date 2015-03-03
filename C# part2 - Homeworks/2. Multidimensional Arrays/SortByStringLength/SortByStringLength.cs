//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("Enter words for the array to sort (same line separated by comma):");
        string input = Console.ReadLine();
        var strings = input.Split(',').ToArray();
        Array.Sort(strings, (x, y) => x.Length.CompareTo(y.Length));

        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine(strings[i]);
        }
    }
}
