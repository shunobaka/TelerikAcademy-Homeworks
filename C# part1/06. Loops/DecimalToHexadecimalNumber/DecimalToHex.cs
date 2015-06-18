//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToHex
{
    static void Main()
    {
        Console.Write("Enter number to convert to hexadecimal: ");
        long inputNumber = long.Parse(Console.ReadLine());
        int highestPower = 0;
        long number = inputNumber;
        int hexNumber = new int();

        while (Math.Pow(16, highestPower) <= inputNumber)
        {
            highestPower++;
        }
        highestPower--;
        Console.Write("{0} in hexadecimal is: ", inputNumber);

        for (int i = highestPower; i >= 0; i--)
        {
            hexNumber = 15;
            while ((long)Math.Pow(16, highestPower) * hexNumber > number)
            {
                hexNumber--;
            }

            switch (hexNumber)
            {
                case 15: Console.Write('F'); break;
                case 14: Console.Write('E'); break;
                case 13: Console.Write('D'); break;
                case 12: Console.Write('C'); break;
                case 11: Console.Write('B'); break;
                case 10: Console.Write('A'); break;
                case 9: Console.Write('9'); break;
                case 8: Console.Write('8'); break;
                case 7: Console.Write('7'); break;
                case 6: Console.Write('6'); break;
                case 5: Console.Write('5'); break;
                case 4: Console.Write('4'); break;
                case 3: Console.Write('3'); break;
                case 2: Console.Write('2'); break;
                case 1: Console.Write('1'); break;
                case 0: Console.Write('0'); break;
            }
            number -= (long)Math.Pow(16, highestPower) * hexNumber;
            highestPower--;
        }

        if (inputNumber == 0)
        {
            Console.Write("0");
        }

        Console.WriteLine();
    }
}
