//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.

//Example:

//input	                        | result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1  | 2, 2, 2

using System;
using System.Linq;

class FindMaxSequence
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
            if (currentElement == previousEle)
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
