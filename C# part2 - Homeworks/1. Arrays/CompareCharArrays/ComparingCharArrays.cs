//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Linq;

class ComparingCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter chars for first array (on single line separated by comma):");
        string array1 = Console.ReadLine();
        Console.WriteLine("Enter chars for second array (on single line separated by comma):");
        string array2 = Console.ReadLine();
        var chars1 = array1.Trim().Split(',').ToArray();
        var chars2 = array2.Trim().Split(',').ToArray();
        bool same = true;
        Console.WriteLine();

//Compares lengths

        if (chars2.Length != chars1.Length)
        {
            Console.WriteLine("Arrays are different");
        }
        else
        {

//Compares chars

            for (int i = 0; i < chars1.Length; i++)
            {
                if (chars1[i] != chars2[i])
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
