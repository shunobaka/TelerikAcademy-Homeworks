//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,).

using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter amount of numbers: ");
        int amountOfNumbers = int.Parse(Console.ReadLine());
        int previousNumber = 0;
        int currentNumber = 0;
        int nextNumber = 1;

        for (int counter = 0; counter < amountOfNumbers; counter++)
        {
            Console.Write(currentNumber + ", ");
            previousNumber = currentNumber;
            currentNumber = nextNumber;
            nextNumber = currentNumber + previousNumber;
        }
        Console.WriteLine();
    }
}
