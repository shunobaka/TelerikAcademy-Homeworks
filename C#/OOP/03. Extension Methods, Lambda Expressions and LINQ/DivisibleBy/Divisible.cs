//Problem 6. Divisible by 7 and 3

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace DivisibleBy
{
    using System;
    using System.Linq;

    class Divisible
    {
        static void Main()
        {
            int[] numbers = new int[] { 0, 1, 2, 21, 4, 5, 6, 7, 21, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 28, 42, 63, 84 };

            int[] divisible = numbers.Where(x => x % 3 == 0 && x % 7 == 0).ToArray();

            Console.WriteLine("Numbers divisible by 3 and 7:");
            Console.WriteLine(string.Join(", ", divisible));

            int[] divisibleWithLinq = (from x in numbers
                                      where x % 3 == 0 && x % 7 == 0
                                      select x).ToArray();

            Console.WriteLine("\nSame using LINQ:");
            Console.WriteLine(string.Join(", ", divisibleWithLinq));
        }
    }
}
