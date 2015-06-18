//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input                                 | result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	| 4 (5 times)

using System;
using System.Collections.Generic;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter line of numbers separated by comma: ");
        string lineOfNumbers = Console.ReadLine();
        int[] numbers = lineOfNumbers.Trim().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
        int currentNumber = 0;
        int counter = 0;
        int mostFrequent = 0;
        int highestCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            currentNumber = numbers[i];
            for (int check = 0; check < numbers.Length; check++)
            {
                if (currentNumber == numbers[check])
                {
                    counter++;
                }
            }

            if (counter > highestCount)
            {
                highestCount = counter;
                mostFrequent = currentNumber;
            }

            counter = 0;
        }

        Console.WriteLine("{0} ({1} times)", mostFrequent,highestCount);
    }
}
