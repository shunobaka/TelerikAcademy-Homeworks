//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter amount of numbers: ");
        int amountOfNumbers = int.Parse(Console.ReadLine());
        decimal number = new decimal();
        decimal sum = new decimal();
        for (int count = 1; count <= amountOfNumbers; count++)
        {
            Console.Write("Enter number {0}: ", count);
            number = decimal.Parse(Console.ReadLine());
            sum = sum + number;
        }
        Console.WriteLine("The sum of the numbers is: " + sum);
    }
}
