//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class BiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        decimal numberA = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        decimal numberB = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        decimal numberC = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number d: ");
        decimal numberD = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number e: ");
        decimal numberE = decimal.Parse(Console.ReadLine());

        if (numberA > numberB && numberA > numberC && numberA > numberD && numberA > numberE)
        {
            Console.WriteLine(numberA);
        }
        else if (numberB > numberA && numberB > numberC && numberB > numberD && numberB > numberE)
        {
            Console.WriteLine(numberB);
        }
        else if (numberC > numberA && numberC > numberB && numberC > numberD && numberC > numberE)
        {
            Console.WriteLine(numberC);
        }
        else if (numberD > numberA && numberD > numberB && numberD > numberC && numberD > numberE)
        {
            Console.WriteLine(numberD);
        }
        else
        {
            Console.WriteLine(numberE);
        }
    }
}
