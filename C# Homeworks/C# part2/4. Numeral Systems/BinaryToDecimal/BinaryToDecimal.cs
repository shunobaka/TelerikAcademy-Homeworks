//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

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
                resultNumber += (int)Math.Pow(2, inputLength);
            }
        }
        Console.WriteLine("The result is {0}", resultNumber);
    }
}
