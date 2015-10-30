// 05. Write a program that removes from given sequence all negative numbers.

namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private static List<int> sequence = new List<int>() { 6, -5, 23, 43, -343, -34, 32, -43, -32, 23};

        public static void Main()
        {
            List<int> positiveNumbers = new List<int>();

            foreach (var number in sequence)
            {
                if (number >= 0)
                {
                    positiveNumbers.Add(number);
                }
            }

            Console.WriteLine("The sequence after removing negatives:");
            Console.WriteLine(string.Join(", ", positiveNumbers));
        }
    }
}
