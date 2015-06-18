//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        number /= 100;
        bool checkThirdDigit = number % 10 == 7;
        Console.WriteLine("The third digit is 7? "  + checkThirdDigit);
    }
}
