//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = int.Parse(input);
        bool checkOdd = !(number % 2 == 0);
        Console.WriteLine("Is the number {0} odd: {1}", number, checkOdd);
    }
}
