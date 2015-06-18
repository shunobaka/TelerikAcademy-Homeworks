//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLarger
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by comma: ");
        int[] array = Console.ReadLine().Trim().Split(',').Select(s => int.Parse(s)).ToArray();
        bool larger = new bool();
        for (int i = 0; i < array.Length; i++)
        {
            larger = CheckIfLargerThanNeightbours(array, i);
            if (larger)
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine("-1");
    }

    static bool CheckIfLargerThanNeightbours(int[] numbers, int number)
    {
        if (number > 0 && number < numbers.Length - 1)
        {
            if (numbers[number] > numbers[number - 1] && numbers[number] > numbers[number + 1])
            {
                return true;
            }
        }
        return false;
    }
}
