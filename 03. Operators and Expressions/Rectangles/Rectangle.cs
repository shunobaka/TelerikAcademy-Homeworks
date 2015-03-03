//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangle
{
    static void Main()
    {
        Console.Write("Height: ");
        string inputHeight = Console.ReadLine();
        decimal height = decimal.Parse(inputHeight);
        Console.Write("Width: ");
        string inputWidth = Console.ReadLine();
        decimal width = decimal.Parse(inputWidth);
        Console.WriteLine("Perimeter: " + 2*(height + width));
        Console.WriteLine("Area: " + height*width);
    }
}
