//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        decimal numberA = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        decimal numberB = decimal.Parse(Console.ReadLine());
        decimal biggerNumber = (numberA > numberB) ? numberA : numberB ;
        Console.WriteLine("The bigger number is {0}", biggerNumber);
    }
}
