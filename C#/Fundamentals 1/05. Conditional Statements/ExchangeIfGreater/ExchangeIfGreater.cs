//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b 
//and exchanges their values if the first one is greater than the
//second one. As a result print the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double numberB = double.Parse(Console.ReadLine());

        if (numberA > numberB)
        {
            numberA = numberA * numberB;
            numberB = numberA / numberB;
            numberA = numberA / numberB;
        }
        Console.WriteLine("{0} {1}",numberA, numberB);
    }
}
