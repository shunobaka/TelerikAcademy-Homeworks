//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class NumbersToN
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int numberN = int.Parse(Console.ReadLine());
        for (int number = 1; number <= numberN; number++)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
