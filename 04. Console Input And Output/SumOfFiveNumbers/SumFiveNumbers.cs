//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers in a line:");
        string numbersLine = Console.ReadLine();
        decimal numberOne = decimal.Parse(numbersLine.Split(' ')[0]);
        decimal numberTwo = decimal.Parse(numbersLine.Split(' ')[1]);
        decimal numberThree = decimal.Parse(numbersLine.Split(' ')[2]);
        decimal numberFour = decimal.Parse(numbersLine.Split(' ')[3]);
        decimal numberFive = decimal.Parse(numbersLine.Split(' ')[4]);
        decimal sum = numberOne + numberTwo + numberThree + numberFour + numberFive;
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}
