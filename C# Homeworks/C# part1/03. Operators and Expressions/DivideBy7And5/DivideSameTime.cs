//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideSameTime
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();
        int number = int.Parse(inputNumber);
        bool checkIfDivisible = number % 5 == 0 && number % 7 == 0;
        Console.WriteLine("The number {0} can be divided by 7 and 5: {1}", number, checkIfDivisible);
    }
}
