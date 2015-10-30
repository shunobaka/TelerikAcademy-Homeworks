// 04. Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.

// Write a program to test whether the method works correctly.

namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private static List<int> numbers = new List<int> { 1, 2, 3, 65, 43, 6, 4, 6, 5, 4, 65, 4, 4, 4, 5, 6, 5, 5, 5, 6, 4 };

        public static void Main()
        {
            List<int> longestSubsequence = FindLongestSubsequence(numbers);

            Console.WriteLine("Longest subsequence of equal numbers:");
            Console.WriteLine(string.Join(", ", longestSubsequence));
        }

        public static List<int> FindLongestSubsequence(List<int> numbers)
        {
            int longestFromIndex = 0;
            int longestToIndex = 0;
            int currentNumber = numbers.FirstOrDefault();
            int lastNumber = numbers.FirstOrDefault();
            int currentLength = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                currentNumber = numbers[i];

                if (currentNumber == lastNumber)
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > longestToIndex - longestFromIndex)
                    {
                        longestToIndex = i - 1;
                        longestFromIndex = longestToIndex - currentLength + 1;
                    }

                    currentLength = 1;
                }

                lastNumber = currentNumber;
            }

            if (currentLength > longestToIndex - longestFromIndex)
            {
                longestToIndex = numbers.Count - 1;
                longestFromIndex = longestToIndex - currentLength + 1;
            }

            List<int> longestSubsequence = new List<int>();

            for (int i = longestFromIndex; i <= longestToIndex; i++)
            {
                longestSubsequence.Add(numbers[i]);
            }

            return longestSubsequence;
        }
    }
}
