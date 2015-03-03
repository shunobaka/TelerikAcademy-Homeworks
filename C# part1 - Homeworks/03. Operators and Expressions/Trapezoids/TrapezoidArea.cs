//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter base A: ");
        decimal baseA = decimal.Parse(Console.ReadLine());
        Console.Write("Enter base B: ");
        decimal baseB = decimal.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        decimal height = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The area of the trapezoid is: " + ((baseA+baseB)*height)/2);
    }
}
