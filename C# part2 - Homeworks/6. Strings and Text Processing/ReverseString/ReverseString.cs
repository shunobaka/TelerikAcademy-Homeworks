//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input:  | output:
//sample  |	elpmas

using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Please enter string to reverse:");
        string input = Console.ReadLine().Trim();
        Console.WriteLine("The string reversed:");
        Console.WriteLine(Reverse(input));
    }

    static string Reverse(string input)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();
    }
}
