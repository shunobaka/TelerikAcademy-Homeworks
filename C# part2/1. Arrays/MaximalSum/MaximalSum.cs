//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input                            | result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8 | 2, -1, 6, 4

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter line of numbers separated by comma: ");
        string lineOfNumbers = Console.ReadLine();
        int[] array1 = lineOfNumbers.Trim().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
        int sumCounter = 0;
        int recordSum = 0;
        string highest = "";
        string current = array1[0] + " ";

        for (int start = 0; start < array1.Length; start++)
        {
            for (int next = start; next < array1.Length; next++)
            {
                sumCounter += array1[next];
                current += array1[next] + ", ";
                if (sumCounter > recordSum)
                {
                    highest = current;
                    recordSum = sumCounter;
                }
            }
            current = "";
            sumCounter = 0;
        }

        highest = highest.TrimEnd(' ');
        highest = highest.TrimEnd(',');

        Console.WriteLine(highest);
    }
}
