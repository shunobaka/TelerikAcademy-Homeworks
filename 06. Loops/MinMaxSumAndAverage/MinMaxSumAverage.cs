//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAverage
{
    static void Main()
    {
        Console.Write("Please number the amount of numbers: ");
        int amountOfNumbers = int.Parse(Console.ReadLine());
        decimal enteredNumber = new decimal();
        decimal min = new decimal();
        decimal max = new decimal();
        decimal sum = 0;
        decimal average = new decimal();

        for (int nomerChislo = 0; nomerChislo < amountOfNumbers; nomerChislo++)
        {
            Console.Write("Enter number: ");
            enteredNumber = int.Parse(Console.ReadLine());
            if (enteredNumber > max)
            {
                max = enteredNumber;
            }
            if (min == 0)
            {
                min = enteredNumber;
            }
            if (enteredNumber < min)
            {
                min = enteredNumber;
            }
            sum += enteredNumber;
        }
        average = sum / amountOfNumbers;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = {0:F2}", average);
    }
}
