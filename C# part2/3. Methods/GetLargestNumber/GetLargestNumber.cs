//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GetLargestNumber
{
    static void Main(string[] args)
    {
        int larger = new int();
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());
        larger = GetMax(a, b);
        larger = GetMax(larger, c);
        Console.WriteLine("The largest is: {0}",larger);
    }

    static int GetMax(int a, int b)
    {
        int larger = new int();
        if (a > b)
        {
            larger = a;
        }
        else if (b > a)
        {
            larger = b;
        }
        else
        {
            larger = a;
        }
        return larger;
    }
}
