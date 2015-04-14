//Problem 1. Shapes

// - Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
// - Define two new classes Triangle and Rectangle that implement the virtual method and return the surface
//   of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
// - Define class Square and suitable constructor so that at initialization height must be kept equal to
//   width and implement the CalculateSurface() method.
// - Write a program that tests the behaviour of the CalculateSurface() method for different shapes
//   (Square, Rectangle, Triangle) stored in an array.

namespace Shapes
{
    using System;
    using Models;

    class Shapes
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5,6),
                new Triangle(6,7),
                new Square(5)
            };

            Console.WriteLine("Surfaces of the shapes:");

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
