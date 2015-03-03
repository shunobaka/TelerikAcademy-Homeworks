//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class EnterNumbers
{
    static int start = 1;
    static int end = 100;


    static void Main()
    {
        Console.WriteLine("Enter 10 numbers such that 1 < a1 < ... < a10 < 100");
        for (int i = 0; i < 10; i++)
        {
            ReadNumber();
        }
    }

    private static void ReadNumber()
    {
        string input = Console.ReadLine();
        int number = new int();

        try
        {
            number = int.Parse(input);
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            start = number;
        }
        catch (FormatException)
        {
            Console.WriteLine("This is not a number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number should be between {0} and {1}", start, end);
        }
    }
}
