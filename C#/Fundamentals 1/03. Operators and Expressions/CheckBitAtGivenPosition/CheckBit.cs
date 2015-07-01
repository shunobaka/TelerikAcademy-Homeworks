//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter index to check: ");
        int index = int.Parse(Console.ReadLine());
        int mask = 1 << index;
        int indexCheck = (number & mask) >> index;
        bool result = indexCheck == 1;
        Console.Write("The bit at index {0} is 1?: ", index);
        Console.WriteLine(result);
    }
}
