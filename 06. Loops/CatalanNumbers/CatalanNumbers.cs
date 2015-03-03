//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the n Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter number for N between 1 and 100: ");
        int numberN = int.Parse(Console.ReadLine());

        while (numberN > 100 || numberN < 0)
        {
            Console.WriteLine("Invalid input for N.");
            Console.Write("Enter number for N between 1 and 100: ");
            numberN = int.Parse(Console.ReadLine());
        }

        int doubleN = 2 * numberN;
        int nPlusOne = numberN + 1;
        BigInteger nFactorial = 1;
        BigInteger doubleNFactorial = 1;
        BigInteger nPlusOneFactorial = 1;
        BigInteger result = new BigInteger();

        for (int counter = 1; counter <= doubleN; counter++)
        {
            doubleNFactorial *= counter;
            if (counter <= nPlusOne)
            {
                nPlusOneFactorial *= counter;
            }
            if (counter <= numberN)
            {
                nFactorial *= counter;
            }
        }
        result = doubleNFactorial / (nPlusOneFactorial * nFactorial);
        Console.WriteLine("The result is {0}", result);
    }
}
