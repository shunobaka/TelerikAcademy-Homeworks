//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Numerics;

class CalculateFormula
{
    static void Main()
    {
        Console.WriteLine("Enter number for N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number for X: ");
        int numberX = int.Parse(Console.ReadLine());
        int numberFactoriel = 1;
        double loopResult = new double();
        double sum = 1d;

        for (int i = 1; i <= numberN; i++)
        {
            numberFactoriel *= i;
            loopResult = numberFactoriel / Math.Pow(numberX, i);
            sum += loopResult;
        }

        Console.WriteLine("The sum is {0:F5}", sum);
    }
}
