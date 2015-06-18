//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter string with 20 or less symbols:");
        string input = Console.ReadLine();

        while (input.Length > 20)
        {
            Console.WriteLine("Invalid length of string!");
            Console.WriteLine("Enter string with 20 or less symbols:");
            input = Console.ReadLine();
        }

        string result = input + new string('*', 20 - input.Length);
        Console.WriteLine(result);
    }
}
