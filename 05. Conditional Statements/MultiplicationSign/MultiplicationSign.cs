//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        decimal numberA = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        decimal numberB = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        decimal numberC = decimal.Parse(Console.ReadLine());

        if (numberA == 0 || numberB == 0 || numberC == 0)
        {
            Console.WriteLine("0");
        }
        else if (numberA < 0)
        {
            if (numberB < 0 ^ numberC < 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
        else
        {
            if (numberB < 0 ^ numberC < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
