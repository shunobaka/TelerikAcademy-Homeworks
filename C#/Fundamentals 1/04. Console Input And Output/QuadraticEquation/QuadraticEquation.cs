//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        double coeffA = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double coeffB = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double coeffC = double.Parse(Console.ReadLine());
        double discriminant = (coeffB*coeffB - 4*coeffA*coeffC);
        if (discriminant == 0)
        {
            Console.WriteLine("The only real root is: x = {0}", (-coeffB)/(2*coeffA));
        }
        else if (discriminant > 0)
        {
            Console.WriteLine("The roots are: x1 = {0}, x2 = {1}",
                ((-coeffB) + Math.Sqrt(discriminant)) / (2 * coeffA),
                ((-coeffB) - Math.Sqrt(discriminant)) / (2 * coeffA));
        }
        else
        {
            Console.WriteLine("There are no real roots.");
        }
    }
}
