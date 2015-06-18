//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;

class MaxSum
{
    static void Main()
    {
        Console.Write("Enter length of array: ");
        int ArrLength = int.Parse(Console.ReadLine());
        Console.Write("Enter number of elements (less than length): ");
        int numberOfEle = int.Parse(Console.ReadLine());
        int[] array = new int[ArrLength];

//Checks if amount of numbers > Length

        while (numberOfEle > ArrLength)
        {
            Console.Write("Number > length. Please enter new number: ");
            numberOfEle = int.Parse(Console.ReadLine());
        }

//Fills array

        for (int i = 0; i < ArrLength; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            array[i] = int.Parse(Console.ReadLine());
        }

//Takes K biggest elements of array
        Console.WriteLine();
        Console.WriteLine("The numbers with the highest sum are:");
        Array.Sort(array);

        for (int i = ArrLength - 1; i > ArrLength - 1 - numberOfEle; i--)
        {
            Console.WriteLine(array[i]);
        }
    }
}
