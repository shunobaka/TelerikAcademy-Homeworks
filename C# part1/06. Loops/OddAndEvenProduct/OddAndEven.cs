//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddAndEven
{
    static void Main()
    {
        int currentNumber = new int();
        int evenProduct = 1;
        int oddProduct = 1;
        bool check;
        string numberLine = Console.ReadLine();
        string[] numbers = numberLine.Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            currentNumber = int.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                evenProduct *= currentNumber;
            }
            else
            {
                oddProduct *= currentNumber;
            }
        }
        check = evenProduct == oddProduct;

        if (check)
        {
            Console.WriteLine("Products are the same");
        }
        else
        {
            Console.WriteLine("Products are different");
        }
    }
}
