// 08.* The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.

// Write a program to find the majorant of given array (if exists).
// Example:
// {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3

namespace MajorantValue
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static int[] numbers = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

        public static void Main()
        {
            var numberOccurences = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (numberOccurences.ContainsKey(number))
                {
                    numberOccurences[number]++;
                }
                else
                {
                    numberOccurences.Add(number, 1);
                }
            }

            foreach (var number in numberOccurences)
            {
                if (number.Value >= (numbers.Length / 2 + 1))
                {
                    Console.WriteLine("The majorant is {0}.", number.Key);
                    return;
                }
            }

            Console.WriteLine("No majorant was found!");
        }
    }
}
