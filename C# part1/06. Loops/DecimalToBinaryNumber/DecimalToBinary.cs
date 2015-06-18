//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

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
