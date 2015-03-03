//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number
//n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int numberCopy = number;
        while (number > 20 || number < 1)
        {
            Console.WriteLine("Invalid number. Enter number between 1 and 20");
        }

        for (int lineCount = 1; lineCount <= numberCopy; lineCount++)
        {
            for (int counter = number - numberCopy + 1; counter <= number; counter++)
            {
                Console.Write(counter + " ");
            }
            number++;
            Console.WriteLine();
        }
    }
}
