//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;

class BiggestNumber
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        decimal numberA = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        decimal numberB = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        decimal numberC = decimal.Parse(Console.ReadLine());
        if (numberA > numberB)
        {
            if (numberA > numberC)
            {
                Console.WriteLine(numberA);
            }
            else
            {
                Console.WriteLine(numberC);
            }
        }
        else
        {
            if (numberB > numberC)
            {
                Console.WriteLine(numberB);
            }
            else
            {
                Console.WriteLine(numberC);
            }
        }
    }
}
