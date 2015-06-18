//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter elements of array separated by space: ");
        string input = Console.ReadLine();
        var array = input.Split(' ').Select(n => int.Parse(n)).ToArray();
        int arrayLength = input.Split(' ').Length;
        int lowestNumber = new int();
        int copy = new int();

        for (int i = 0; i < arrayLength; i++)
        {
            lowestNumber = i;
            copy = array[i];
            for (int j = i + 1; j < arrayLength; j++)
            {
                if (array[lowestNumber] > array[j])
                {
                    lowestNumber = j;
                }
            }

            if (lowestNumber != i)
            {
                array[i] = array[lowestNumber];
                array[lowestNumber] = copy;
            }
        }

        Console.WriteLine("Here's the array sorted: ");

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
