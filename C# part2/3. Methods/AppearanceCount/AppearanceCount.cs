//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AppearanceCount
{
    static void Main()
    {
        int counts = new int();
        Console.WriteLine("Enter numbers separated by comma:");
        int[] numbers = Console.ReadLine().Trim().Split(',').Select(s => int.Parse(s)).ToArray();
        Console.Write("Enter number to count: ");
        int numberToCount = int.Parse(Console.ReadLine());

        counts = CountAppearanceInArray(numbers, numberToCount);
        Console.WriteLine(counts);
    }

    static int CountAppearanceInArray(int[] numbers, int numberToCount)
    {
        int count = new int();

        foreach (var number in numbers)
        {
            if (number == numberToCount)
            {
                count++;
            }
        }
        return count;
    }
}
