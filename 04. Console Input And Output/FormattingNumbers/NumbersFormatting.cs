//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c

//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class NumbersFormatting
{
    static void Main()
    {
        Console.Write("Enter a (between 0 and 500): ");
        int numberA = int.Parse(Console.ReadLine());
        while (numberA < 0 || numberA > 500)
        {
            Console.WriteLine("Invalid input for a");
            Console.Write("Enter a (between 0 and 500): ");
            numberA = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter b: ");
        float numberB = float.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        float numberC = float.Parse(Console.ReadLine());
        string binary = Convert.ToString(numberA, 2);
        Console.WriteLine("{0,-10:X}|{1,10:F10}|{2,10:N2}|{3,-10:0.000}",numberA,binary.PadLeft(10, '0'),numberB,numberC);
    }
}
