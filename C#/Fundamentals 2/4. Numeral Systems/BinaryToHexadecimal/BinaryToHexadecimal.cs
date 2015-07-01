//Problem 6. binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        long input = long.Parse(Console.ReadLine());
        string hexNumber = string.Empty;
        hexNumber = BinaryToHex(input);
        Console.WriteLine("The number in hexadecimal is: {0}", hexNumber);
    }

    static string BinaryToHex(long binaryNumber)
    {
        string hexNumber = string.Empty;
        while (binaryNumber > 0)
        {
            switch (binaryNumber % 10000)
            {
                case 0: hexNumber = "0" + hexNumber; break;
                case 1: hexNumber = "1" + hexNumber; break;
                case 10: hexNumber = "2" + hexNumber; break;
                case 11: hexNumber = "3" + hexNumber; break;
                case 100: hexNumber = "4" + hexNumber; break;
                case 101: hexNumber = "5" + hexNumber; break;
                case 110: hexNumber = "6" + hexNumber; break;
                case 111: hexNumber = "7" + hexNumber; break;
                case 1000: hexNumber = "8" + hexNumber; break;
                case 1001: hexNumber = "9" + hexNumber; break;
                case 1010: hexNumber = "A" + hexNumber; break;
                case 1011: hexNumber = "B" + hexNumber; break;
                case 1100: hexNumber = "C" + hexNumber; break;
                case 1101: hexNumber = "D" + hexNumber; break;
                case 1110: hexNumber = "E" + hexNumber; break;
                case 1111: hexNumber = "F" + hexNumber; break;
            }
            binaryNumber /= 10000;
        }
        return hexNumber;
    }
}
