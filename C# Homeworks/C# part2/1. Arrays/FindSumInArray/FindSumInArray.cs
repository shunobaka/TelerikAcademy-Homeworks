//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).

//Example:

// array	           | S	| result
// 4, 3, 1, 4, 2, 5, 8 | 11	| 4, 2, 5
//

using System;
using System.Collections.Generic;
using System.Linq;

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter line of numbers separated by comma: ");
        string lineOfNumbers = Console.ReadLine();
        int[] numbers = lineOfNumbers.Trim().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
        Console.Write("Enter sum to find: ");
        int searchedSum = int.Parse(Console.ReadLine());
        int currentSum = 0;
        string sequence = "";

        for (int start = 0; start < numbers.Length; start++)
        {
            for (int i = start; i < numbers.Length; i++)
            {
                sequence += numbers[i] + ", ";
                currentSum += numbers[i];
                if (currentSum == searchedSum)
                {
                    sequence = sequence.TrimEnd(' ');
                    sequence = sequence.TrimEnd(',');
                    Console.WriteLine("Sequence giving this sum:");
                    Console.WriteLine(sequence);
                    return;
                }
            }
            currentSum = 0;
            sequence = "";
        }
        Console.WriteLine("Sum not present in the array!");
    }
}
