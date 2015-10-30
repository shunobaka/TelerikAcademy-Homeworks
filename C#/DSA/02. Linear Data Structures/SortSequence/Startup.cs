// 03. Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.

namespace SortSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter numbers:");

            string input = Console.ReadLine();
            List<int> numbers = new List<int>();

            while (!string.IsNullOrWhiteSpace(input))
            {
                numbers.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            numbers = numbers.OrderBy(x => x).ToList();

            Console.WriteLine("Ordered sequence: {0}", string.Join(", ", numbers));
        }
    }
}
