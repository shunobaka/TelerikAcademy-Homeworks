using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SolveTasks
{
    static void Main()
    {
        
    }

    static void ReverseDigits()
    {
        Console.WriteLine("Please enter a number:");
        string input = Console.ReadLine();
        while (int.Parse(input) < 0)
        {
            Console.WriteLine("Invalid number! Should not be negative!");
            Console.WriteLine("Please enter new number:");
            input = Console.ReadLine();
        }
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        int reversedNumber = int.Parse(new string(arr));
        Console.WriteLine(reversedNumber);
    }

    static void SolveEquation()
    {
        Console.Write("Enter value of a (different from 0): ");
        double a = double.Parse(Console.ReadLine());
        while (a == 0)
        {
            Console.WriteLine("Invalid value for a!");
            Console.Write("Enter value of a (different from 0): ");
            a = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value of c: ");
        double c = double.Parse(Console.ReadLine());
        double x1 = new double();
        double x2 = new double();
        if (Math.Sqrt(b * b - 4 * a * c) < 0)
        {
            Console.WriteLine("There are no solutions.");
        }
        else if (Math.Sqrt(b * b - 4 * a * c) == 0)
        {
            x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("The solution is: x1 = x2 = {0}", x1);
        }
        else
        {
            x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            x2 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("The solutions are: x1 = {0} , x2 = {1}", x1, x2);
        }
    }

    static void AverageOfSequence()
    {
        Console.WriteLine("Please enter sequence of numbers separated by comma:");
        int[] numbers = Console.ReadLine().Trim().Split(',').Select(x => int.Parse(x)).ToArray();
        int sum = new int();
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        sum /= numbers.Length;
        Console.WriteLine("The average of the sequence is: {0}", sum);
    }
}
