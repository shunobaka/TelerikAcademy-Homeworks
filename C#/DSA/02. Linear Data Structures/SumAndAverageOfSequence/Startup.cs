// 01. Write a program that reads from the console a sequence of positive integer numbers.

// The sequence ends when empty line is entered.
// Calculate and print the sum and average of the elements of the sequence.
// Keep the sequence in List<int>.

namespace Linear_Data_Structures
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private const string SumMessageFormat = "The sum is {0}";
        private const string AverageMessageFormat = "The average is {0}";

        public static void Main()
        {
            List<int> numbers = ReadInputNumbers();

            FindSumAndAverage(numbers);
        }

        public static List<int> ReadInputNumbers()
        {
            Console.WriteLine("Please enter numbers:");

            string input = Console.ReadLine();
            List<int> numbers = new List<int>();

            while (!string.IsNullOrWhiteSpace(input))
            {
                numbers.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            return numbers;
        }

        public static void FindSumAndAverage(IList<int> numbers)
        {
            long sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(string.Format(SumMessageFormat, sum));
            Console.WriteLine(string.Format(AverageMessageFormat, sum / numbers.Count));
        }
    }
}
