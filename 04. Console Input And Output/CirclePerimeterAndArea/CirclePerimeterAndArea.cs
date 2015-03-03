//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Circle's radius: ");
        double radius = double.Parse(Console.ReadLine());
        double area = (double)Math.PI * radius * radius;
        double perimeter = (double)Math.PI * radius * 2;
        Console.WriteLine("The perimeter of a circle with radius {0} is: {1:F2}", radius, perimeter);
        Console.WriteLine("The area of a circle with radius {0} is: {1:F2}", radius, area);
    }
}
