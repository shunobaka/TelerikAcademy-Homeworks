//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm.

//Example:
//Input: 10, -32, 54, -24, 53, -123, 231, 1, -32, -12, -42, 11, 32, 11, 2, 99, 0, -32
//Output -123, -42, -32, -32, -32, -24, -12, 0, 1, 2, 10, 11, 11, 32, 53, 54, 99, 231

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class QuickSort
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eneter numbers separated by a comma: ");
        int[] numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
        SortArray(numbers, 0, numbers.Length - 1);
        Console.WriteLine(String.Join(", ", numbers));
    }

    static void SortArray(int[] numbers, int left, int right)
    {
        int pivot;

        if (left < right)
        {
            pivot = Partition(numbers, left, right);

            if (pivot > 1)
            {
                SortArray(numbers, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                SortArray(numbers, pivot + 1, right);
            }
        }
    }

    static int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];

        while (true)
        {
            while (numbers[left] < pivot) ++left;
            while (numbers[right] > pivot) --right;

            if (numbers[right] == numbers[left] && numbers[left] == pivot)
                ++left;

            if (left < right)
            {
                numbers[left] ^= numbers[right];
                numbers[right] ^= numbers[left];
                numbers[left] ^= numbers[right];
            }
            else
            {
                return right;
            }
        }
    }
}
