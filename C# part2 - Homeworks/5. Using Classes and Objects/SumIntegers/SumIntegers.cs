//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers separated by space:");
            string input = Console.ReadLine();
            int sum = SumOfNumbersInString(input);
            Console.WriteLine("The sum is: {0}", sum);
        }

        static int SumOfNumbersInString(string input)
        {
            int sum = new int();
            int[] numbers = input.Trim().Split(' ').Select(n => int.Parse(n)).ToArray();
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
