//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.

//Example:

//input	               | result
//3, 2, 3, 4, 2, 2, 4  | 2, 3, 4

using System;
using System.Linq;

class MaxIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter line of numbers separated by comma: ");
        string lineOfNumbers = Console.ReadLine();
        int[] array1 = lineOfNumbers.Trim().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
        int lengthCounter = 0;
        int recordLength = 0;
        string longest = "";
        string current = array1[0] + " ";
        int currentElement = new int();
        int previousEle = 0;

        for (int i = 0; i < lineOfNumbers.Trim().Split(',').Length; i++)
        {
            currentElement = array1[i];
            if (currentElement == previousEle + 1)
            {
                lengthCounter++;
                if (i == lineOfNumbers.Split(',').Length - 1)
                {
                    current += currentElement;
                }
                else
                {
                    current += currentElement + ", ";
                }
            }
            else
            {
                lengthCounter = 1;
                current = array1[i] + ", ";
            }
            if (recordLength < lengthCounter)
            {
                longest = current;
                recordLength = lengthCounter;
            }

            previousEle = array1[i];
        }
        longest = longest.TrimEnd(' ');
        longest = longest.TrimEnd(',');

        Console.WriteLine(longest);
    }
}
