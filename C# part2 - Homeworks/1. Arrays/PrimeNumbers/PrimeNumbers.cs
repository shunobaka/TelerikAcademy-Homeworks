//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Enter max number: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        bool[] primes = new bool[n];
//Fills the bool array with true
        for (int i = 2; i < primes.Length; i++)
        {
            primes[i] = true; 
        }
//Fills the array with the numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }
//Changes all non-prime numbers to false
        for (int i = 2; i < primes.Length; i++)
        {
            if (primes[i])
            {
                for (int j = 2; j*i < primes.Length; j++)
                {
                    primes[j * i] = false;
                }
            }
        }
//Prints all primes
        Console.WriteLine("The prime numbers up to {0} are:", n);
        for (int i = 0; i < primes.Length; i++)
        {
            if (primes[i])
            {
                Console.Write(numbers[i] + ", ");
            }
        }
        Console.WriteLine();
    }
}
