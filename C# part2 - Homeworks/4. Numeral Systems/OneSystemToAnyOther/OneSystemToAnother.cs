//Problem 7. One system to any other

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OneSystemToAnother
{
    static void Main()
    {
        long decimalNumber = new int();
        string result = string.Empty;
        Console.Write("Enter numeral base of input number (2 <= s <= 16): ");
        int systemBase = int.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        Console.Write("Enter numeral base of output number (2 <= d <= 16): ");
        int outputBase = int.Parse(Console.ReadLine());
        decimalNumber = BaseToDecimal(input, systemBase);
        result = DecimalToBase(decimalNumber, outputBase);
        Console.WriteLine("The result is: {0}",result);
    }

    static long BaseToDecimal(string number, int systemBase)
    {
        long decimalNumber = 0;
        for (int i = 0; i < number.Length ; i++)
        {
            int digit = 0;
            if (number[i] >= '0' && number[i] <= '9')
            {
                digit = number[i] - '0';
            }
            else if (number[i] >= 'A' && number[i] <= 'F')
            {
                digit = number[i] - 'A' + 10;
            }
            decimalNumber += digit * (long)Math.Pow(systemBase, number.Length - i - 1);
        }
        return decimalNumber;
    }

    static string DecimalToBase(long decimalNumber, int systemBase)
    {
        long digit = 0;
        string number = string.Empty;
        while (decimalNumber > 0)
        {
            digit = (decimalNumber % systemBase);
            if (digit >= 0 && digit <= 9)
            {
                number = (char)(digit + '0') + number;
            }
            else if (digit >= 10 && digit <= 16)
            {
                number = (char)(digit - 10 + 'A') + number;
            }
            decimalNumber /= systemBase;
        }
        return number;
    }
}
