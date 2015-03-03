//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.Write("Enter amount of random numbers: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter min number in range: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max number in range: ");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int randomNumber = new int();

        while (min == max)
        {
            Console.WriteLine("Max must be different from min!");
            Console.Write("Enter max number in range: ");
            max = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numberN; i++)
        {
            randomNumber = rnd.Next(min, max);
            Console.Write("{0} ",randomNumber);
        }

        Console.WriteLine();
    }
}
