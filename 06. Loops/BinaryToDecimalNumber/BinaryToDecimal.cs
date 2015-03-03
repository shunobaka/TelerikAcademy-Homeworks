//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary to convert: ");
        string input = Console.ReadLine();
        int number = new int();
        int inputLength = input.Length;
        long resultNumber = 0;

        foreach (char numberChar in input)
        {
            inputLength--;
            number = int.Parse(numberChar.ToString());
            if (number == 1)
            {
                resultNumber +=(int)Math.Pow(2, inputLength);
            }
        }
        Console.WriteLine("The result is {0}",resultNumber);
    }
}
