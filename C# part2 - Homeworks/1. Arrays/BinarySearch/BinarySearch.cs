//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter line of numbers separated by comma: ");
        string lineOfNumbers = Console.ReadLine();
        int[] numbers = lineOfNumbers.Trim().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
        Array.Sort(numbers);
        Console.Write("Enter number to search: ");
        int searched = int.Parse(Console.ReadLine());
        int start = 0;
        int end = numbers.Length;
        int middle = new int();

        while (start <= end)
        {
            middle = (start + end)/2;
            if (searched == numbers[middle])
            {
                Console.WriteLine("The index of the searched number is: {0}", middle);
                return;
            }
            else if (searched < numbers[middle])
            {
                end = middle - 1;
            }
            else
            {
                start = middle + 1;
            }
        }
    }
}
