//Problem 1. Square root

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Enter number to find square root of:");
        string input = Console.ReadLine();
        double number = new int();
        double sqrt = new int();
            
        try
        {
            number = int.Parse(input);

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            sqrt = Math.Sqrt(number);
            Console.WriteLine(sqrt);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }
    }
}
