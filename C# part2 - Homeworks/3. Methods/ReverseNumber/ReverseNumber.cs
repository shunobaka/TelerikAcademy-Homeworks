//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        string reversedNumber = string.Empty;
        Console.Write("Reversed number: ");
        reversedNumber = ReverseANumber(number);
        Console.WriteLine(reversedNumber);
    }

    static string ReverseANumber(int number)
    {
        string reversedNumber = string.Empty;
        while (number > 0)
        {
            reversedNumber += number % 10;
            number /= 10;
        }
        return reversedNumber;
    }
}
