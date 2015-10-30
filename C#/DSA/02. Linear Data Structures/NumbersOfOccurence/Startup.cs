// 07. Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.

namespace NumbersOfOccurence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private static int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

        public static void Main()
        {
            var groupedNumbers = numbers.GroupBy(x => x);

            foreach (var group in groupedNumbers)
            {
                Console.WriteLine("{0} -> {1}", group.Key, group.Count());
            }
        }
    }
}
