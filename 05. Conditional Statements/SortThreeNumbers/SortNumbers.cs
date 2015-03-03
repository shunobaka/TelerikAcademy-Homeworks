//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;

class SortNumbers
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
            if (numberB > numberC)
            {
                Console.WriteLine("{0} {1} {2}", numberA, numberB,numberC);
            }
            else
            {
                if (numberA > numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberA, numberC, numberB);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", numberC, numberA, numberB);
                }
            }
        }
        else
        {
            if (numberA > numberC)
            {
                Console.WriteLine("{0} {1} {2}", numberB, numberA, numberC);
            }
            else
            {
                if (numberB > numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberB, numberC, numberA);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", numberC, numberB, numberA);
                }
            }
        }
    }
}
