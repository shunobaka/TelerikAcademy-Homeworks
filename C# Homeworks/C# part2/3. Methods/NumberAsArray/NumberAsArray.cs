//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as 
//arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberAsArray
{
    static void Main()
    {
        int result = new int();
        Console.WriteLine("Please enter a line of digits for first array separated by comma:");
        int[] numberOneArr = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("Please enter a line of digits for second array separated by comma:");
        int[] numberTwoArr = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

        result = AddNumbersAsArrays(numberOneArr, numberTwoArr);
        Console.WriteLine("The result is: {0}", result);
    }

    static int AddNumbersAsArrays(int[] numberOneArr, int[] numberTwoArr)
    {
        int sum = new int();
        int numberOne = new int();
        int numberTwo = new int();

        for (int i = 0; i < numberOneArr.Length; i++)
        {
            numberOne += numberOneArr[i] * (int)Math.Pow(10, numberOneArr.Length - 1 - i);
        }

        for (int i = 0; i < numberTwoArr.Length; i++)
        {
            numberTwo += numberTwoArr[i] * (int)Math.Pow(10, numberTwoArr.Length - 1 - i);
        }

        sum = numberOne + numberTwo;
        return sum;
    }
}
