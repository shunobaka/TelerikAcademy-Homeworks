//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements
//(also known as the number of combinations) is calculated by the following formula: n! / (k! * (n-k)!).
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
//Try to use only two loops.

using System;
using System.Numerics;

class FormulaCalculate
{
    static void Main()
    {
        Console.Write("Enter number for N between 1 and 100: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter number for K between 1 and 100 and less than n: ");
        int numberK = int.Parse(Console.ReadLine());

        //Check if 1 < K < N < 100
        
        while (numberN > 100 || numberK < 1 || numberK > numberN)
        {
            Console.WriteLine("Invalid numbers for N and K");
            Console.Write("Enter number for N between 1 and 100: ");
            numberN = int.Parse(Console.ReadLine());
            Console.Write("Enter number for K between 1 and 100 and less than n: ");
            numberK = int.Parse(Console.ReadLine());
        }

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        int NMinusK = numberN - numberK;
        BigInteger NMinusKFactorial = 1;
        BigInteger Result = new BigInteger();
        
        //Calculates factorial

        for (int counter = 1; counter <= numberN; counter++)
        {
            nFactorial *= counter;
            if (counter <= numberK)
            {
                kFactorial *= counter;
            }
            if (counter <= NMinusK)
            {
                NMinusKFactorial *= counter;
            }
        }
        Result = nFactorial / (kFactorial * NMinusKFactorial);
        Console.WriteLine("The result is {0}", Result);
    }
}
