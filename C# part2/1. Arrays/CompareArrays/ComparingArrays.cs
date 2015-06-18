//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class ComparingArrays
{
    static void Main()
    {
        Console.WriteLine("Enter numbers for first array (on single line separated by space):");
        string array1 = Console.ReadLine();
        Console.WriteLine("Enter numbers for second array (on single line separated by space):");
        string array2 = Console.ReadLine();
        var numbers1 = array1.Split(' ').Select(n => int.Parse(n)).ToArray();
        var numbers2 = array2.Split(' ').Select(n => int.Parse(n)).ToArray();
        bool same = true;
        int length = Math.Max(numbers1.Length, numbers2.Length);
        Console.WriteLine();

//Compares lengths

        if (numbers2.Length != numbers1.Length)
        {
            Console.WriteLine("Arrays are different");
        }
        else
        {

//Compares values

            for (int i = 0; i < length; i++)
            {
                if (numbers1[i] != numbers2[i])
                {
                    same = false;
                }
            }

            if (same)
            {
                Console.WriteLine("Arrays are the same");
            }
            else
            {
                Console.WriteLine("Arrays are different");
            }
        }
    }
}
