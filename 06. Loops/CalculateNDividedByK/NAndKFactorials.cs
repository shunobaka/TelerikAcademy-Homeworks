//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

class NAndKFactorials
{
    static void Main()
    {
        Console.Write("Enter number for n between 1 and 100: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter number for k between 1 and 100 and less than n: ");
        int numberK = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;

        for (int counter = 1; counter <= numberN; counter++)
        {
            nFactorial *= counter;
            if (counter <= numberK)
            {
                kFactorial *= counter;
            }
        }
        Console.WriteLine("N! / K! = {0}",nFactorial / kFactorial);
    }
}
