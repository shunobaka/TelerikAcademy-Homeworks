//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            CalculateFactorials(array);
        }

        static void CalculateFactorials(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                BigInteger factorial = Factorial(array[i]);
                Console.WriteLine(factorial);
            }
        }

        static BigInteger Factorial(int i)
        {
            BigInteger fact = i;
            while (i > 1)
            {
                fact *= i - 1;
                i--;
            }
            return fact;
        }
    }
}
