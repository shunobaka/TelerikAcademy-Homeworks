//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurface
{
    class TriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("Find the surface by given:");
            Console.WriteLine("1. Side and an altitude to it");
            Console.WriteLine("2. Three sides");
            Console.WriteLine("3. Two sides and an angle between them");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());
            double area = new double();
            switch (choice)
            {
                case 1: area = FindAreaBySideAndAltitude(); break;
                case 2: area = FindAreaByThreeSides(); break;
                case 3: area = FindAreaBySidesAndAngle(); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
            Console.WriteLine("The area is: {0:F2}", area);
        }

        static double FindAreaBySideAndAltitude()
        {
            Console.Write("Please enter the side: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Please enter the altitude: ");
            double altitude = double.Parse(Console.ReadLine());
            double area = (side * altitude) / 2;
            return area;
        }

        static double FindAreaByThreeSides()
        {
            Console.Write("Please enter side one: ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.Write("Please enter side two: ");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.Write("Please enter side three: ");
            double sideThree = double.Parse(Console.ReadLine());
            double area = new double();
            double semiP = (sideOne + sideTwo + sideThree) / 2;
            area = Math.Sqrt(semiP * (semiP - sideThree) * (semiP - sideOne) * (semiP - sideTwo));
            return area;
        }

        static double FindAreaBySidesAndAngle()
        {
            Console.Write("Please enter side one: ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.Write("Please enter side two: ");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.Write("Please enter angle between them: ");
            double angle = double.Parse(Console.ReadLine());
            double area = new double();
            area = ((sideOne * sideTwo) / 2) * Math.Sin(angle / 180 * Math.PI);
            return area;
        }
    }
}
