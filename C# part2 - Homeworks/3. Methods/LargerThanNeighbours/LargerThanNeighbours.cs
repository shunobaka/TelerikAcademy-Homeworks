//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by comma: ");
        int[] array = Console.ReadLine().Trim().Split(',').Select(s => int.Parse(s)).ToArray();
        Console.Write("Enter index to check (between 0 and {0}): ",array.Length - 1);
        int index = int.Parse(Console.ReadLine());
        bool larger = new bool();
        larger = CheckIfLargerThanNeightbours(array, index);
        Console.WriteLine(larger);
    }

    static bool CheckIfLargerThanNeightbours(int[] numbers, int number)
    {
        if (number > 0 && number < numbers.Length - 1)
        {
            if (numbers[number] > numbers[number - 1] && numbers[number] > numbers[number + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (number == 0 || number == numbers.Length - 1)
        {
            Console.WriteLine("Index doesn't have two neighbours!");
            Environment.Exit(-1);
        }
        else
        {
            Console.WriteLine("Index not in range!");
            Environment.Exit(-1);
        }
        return false;
    }
}

