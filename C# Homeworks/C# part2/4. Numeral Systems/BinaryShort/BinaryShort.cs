//Problem 8. Binary short

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Please enter a signed short: ");
        short number = short.Parse(Console.ReadLine());
        string binaryShort = string.Empty;
        binaryShort = SignedShortToBinary(number);
        Console.WriteLine("The binary representation is: {0}",binaryShort);
    }

    static string SignedShortToBinary(short number)
    {
        string binaryShort = string.Empty;
        string firstBit = string.Empty;

        if (number < 0)
        {
            firstBit = "1";
            number = (short)-number;
            number = (short)(32768 - number);
        }
        else
        {
            firstBit = "0";
        }

        while (number > 0)
        {
            binaryShort = (number % 2).ToString() + binaryShort;
            number /= 2;
        }
        binaryShort = firstBit + new string('0', 16 - binaryShort.Length - 1) + binaryShort;
        return binaryShort;
    }
}
