//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInCircleAndOutOfRect
{
    static void Main()
    {
        decimal radius = 1.5M;
        Console.Write("Enter x: ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        decimal y = decimal.Parse(Console.ReadLine());
        bool inTheCircle = ((x-1)*(x-1) + (y-1)*(y-1)) <= radius * radius;
        bool notInRectangle = x < -1 || x > 5 || y < -1 || y > 1 ;
        if (inTheCircle && notInRectangle)
        {
            Console.WriteLine("Point({0};{1}) is in the circle and outside of the Rectangle!", x, y);
        }
        else
        {
            Console.WriteLine("Point({0};{1}) is either outside of the circle or in the rectangle.", x, y);
        }
    }
}
