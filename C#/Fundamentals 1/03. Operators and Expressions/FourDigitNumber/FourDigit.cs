//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).

using System;

class FourDigit
{
    static void Main()
    {
        Console.Write("Enter 4-digit number: ");
        int number = int.Parse(Console.ReadLine());
        while (number < 1000 || number > 9999)
        {
            Console.Write("Invalid number. Enter number 4-digit number: ");
            number = int.Parse(Console.ReadLine());
        }
        int d = number % 10;
        number /= 10;
        int c = number % 10;
        number /= 10;
        int b = number % 10;
        number /= 10;
        int a = number % 10;
        Console.WriteLine("The sum of digits is " + (a + b + c + d));
        Console.WriteLine("The number in reverse is {0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("The number with last 2 digits infront is {0}{1}{2}{3}", d,a,b,c);
        Console.WriteLine("The number with exchanged 2nd and 3rd digit is {0}{1}{2}{3}",a,c,b,d);
    }
}
