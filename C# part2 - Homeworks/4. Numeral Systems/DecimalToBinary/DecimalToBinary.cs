//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter number to convert to binary: ");
        long inputNumber = long.Parse(Console.ReadLine());
        int highestPower = 0;
        long number = inputNumber;

        while (Math.Pow(2, highestPower) <= number)
        {
            highestPower++;
        }
        highestPower--;
        Console.Write("{0} in binary is: ", inputNumber);

        for (int i = highestPower; i >= 0; i--)
        {
            if (Math.Pow(2, highestPower) <= number)
            {
                Console.Write("1");
                number -= (long)Math.Pow(2, highestPower);
            }
            else
            {
                Console.Write("0");
            }
            highestPower--;
        }

        if (inputNumber == 0)
        {
            Console.Write("0");
        }

        Console.WriteLine();
    }
}
