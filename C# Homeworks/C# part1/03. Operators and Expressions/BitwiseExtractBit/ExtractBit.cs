//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 1 << 3;
        uint thirdBit = (number & mask) >> 3;
        Console.Write("The third bit is: ");
        Console.WriteLine(thirdBit);
    }
}
