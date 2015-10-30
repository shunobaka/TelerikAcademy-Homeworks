// 06. Write a program that removes from given sequence all numbers that occur odd number of times.
   
// Example:
// {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}

namespace RemoveOddOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private static List<int> sequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

        public static void Main()
        {
            var numbersWithEvenOccurences = sequence.Where(x => sequence.Count(y => y == x) % 2 == 0);

            Console.WriteLine(string.Join(", ", numbersWithEvenOccurences));
        }
    }
}
