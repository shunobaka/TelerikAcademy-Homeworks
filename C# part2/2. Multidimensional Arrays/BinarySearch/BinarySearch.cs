//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter line of numbers separated by space: ");
        string lineOfNumbers = Console.ReadLine();
        int[] numbers = lineOfNumbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        Console.Write("Enter max element K: ");
        int inputNumber = int.Parse(Console.ReadLine());
        int numberCopy = inputNumber;
        int index = new int();

        if (numbers[0] > inputNumber)
        {
            Console.WriteLine("There's no element in the array <= K");
            return;
        }

        while (true)
        {
            index = Array.BinarySearch(numbers, numberCopy);
            if (index >= 0)
            {
                Console.WriteLine("The highest number <= K is: {0}", numbers[index]);
                return;
            }
            numberCopy--;
        }
    }
}

