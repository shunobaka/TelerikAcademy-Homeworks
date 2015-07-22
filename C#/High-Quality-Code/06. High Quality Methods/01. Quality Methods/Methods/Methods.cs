namespace Methods
{
    using System;

    public class Methods
    {
        private enum Formatting
        {
            Percent,
            Round,
            AlignRight
        }

        private enum LinePosition
        {
            Horizontal,
            Vertical,
            Overlapping,
            Other
        }

        private static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("The sides of the triangle must be positive numbers!");
            }

            if ((sideA + sideB) <= sideC || (sideA + sideC) <= sideB || (sideB + sideC) <= sideA)
            {
                throw new ArgumentException("The sum of no two sides of the triangle must be less or equal to the third side!");
            }

            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

        private static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("The parameter is not a valid digit!");
            }
        }

        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Elements cannot be null or empty!");
            }

            int maxElement = 0;

            for (int i = 1; i < elements.Length; i++)
            {
                if (i == 1)
                {
                    maxElement = elements[i];
                    continue;
                }

                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }
        
        private static void PrintAsNumber(object number, Formatting format)
        {
            switch (format)
            {
                case Formatting.Round:
                    Console.WriteLine("{0:f2}", number);
                    break;
                case Formatting.Percent:
                    Console.WriteLine("{0:p0}", number);
                    break;
                case Formatting.AlignRight:
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("Invalid formatting parameter!");
            }
        }

        private static double CalcDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double subtractionProductX = (secondPointX - firstPointX) * (secondPointX - firstPointX);
            double subtractionProductY = (secondPointY - firstPointY) * (secondPointY - firstPointY);
            double distance = Math.Sqrt(subtractionProductX + subtractionProductY);

            return distance;
        }

        private static LinePosition GetLinePosition(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            if (firstPointX == secondPointX && firstPointY == secondPointY)
            {
                return LinePosition.Overlapping;
            }
            else if (firstPointX == secondPointX) 
            {
                return LinePosition.Vertical;
            }
            else if (firstPointY == secondPointY)
            {
                return LinePosition.Horizontal;
            }
            else
            {
                return LinePosition.Other;
            }
        }

        private static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, Formatting.Round);
            PrintAsNumber(0.75, Formatting.Percent);
            PrintAsNumber(2.30, Formatting.AlignRight);

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine(GetLinePosition(3, -1, 3, 2.5));

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 3, 11), "Vidin", "gamer, high results");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
