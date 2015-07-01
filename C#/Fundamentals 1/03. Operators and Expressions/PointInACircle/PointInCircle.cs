//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
{
    static void Main()
    {
        int radius = 2;
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        bool inTheCircle = (x * x + y * y) <= radius * radius;
        if (inTheCircle == true)
        {
            Console.WriteLine("Point({0};{1}) is in the circle!",x,y);
        }
        else
        {
            Console.WriteLine("Point ({0};{1}) is outside of the circle!", x, y);
        }
    }
}
