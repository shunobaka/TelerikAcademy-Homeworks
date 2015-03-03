//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary to convert: ");
        string input = Console.ReadLine();
        int inputLength = input.Length;
        long resultNumber = 0;
        int hexNumber = new int();

        foreach (char numberChar in input)
        {
            inputLength--;

            switch (numberChar)
            {
                case '0': hexNumber = 0; break;
                case '1': hexNumber = 1; break;
                case '2': hexNumber = 2; break;
                case '3': hexNumber = 3; break;
                case '4': hexNumber = 4; break;
                case '5': hexNumber = 5; break;
                case '6': hexNumber = 6; break;
                case '7': hexNumber = 7; break;
                case '8': hexNumber = 8; break;
                case '9': hexNumber = 9; break;
                case 'A': hexNumber = 10; break;
                case 'B': hexNumber = 11; break;
                case 'C': hexNumber = 12; break;
                case 'D': hexNumber = 13; break;
                case 'E': hexNumber = 14; break;
                case 'F': hexNumber = 15; break;
                default: Console.WriteLine("Not a valid hexadecimal number!"); return;
            }

            resultNumber += (int)(Math.Pow(16, inputLength)*hexNumber);
        }
        Console.WriteLine("The result is {0}", resultNumber);
    }
}
