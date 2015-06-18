//Problem 11. Format number

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;
using System.Text;

class FormatNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:D} - in decimal",number);
        Console.WriteLine("{0,15:X} - in hexadecimal", number);
        Console.WriteLine("{0,15:P} - in percentage", number);
        Console.WriteLine("{0,15:E} - in scientific notation", number);
    }
}
