//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class CheckIfPrime
{
    static void Main()
    {
        Console.Write("Enter number between 0 and 100: ");
        int number = int.Parse(Console.ReadLine());

        while (number < 0 || number > 100)
        {
            Console.Write("Invalid number. Enter number between 0 and 100: ");
            number = int.Parse(Console.ReadLine());
        }

        bool checkNumberIfPrime;
        if (number == 0 || number == 1)
        {
            checkNumberIfPrime = false;
            Console.WriteLine(checkNumberIfPrime);
        }
        else
        {
            for (int a = 2; a <= number / 2; a++)
            {
                if (number % a == 0)
                {
                    checkNumberIfPrime = false;
                    Console.WriteLine(checkNumberIfPrime);
                    return;
                }
            }
            checkNumberIfPrime = true;
            Console.WriteLine(checkNumberIfPrime);
        }
    }
}
