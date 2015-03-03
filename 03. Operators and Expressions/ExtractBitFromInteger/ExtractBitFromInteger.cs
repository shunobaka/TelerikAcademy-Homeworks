//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter index to extract: ");
        int index = int.Parse(Console.ReadLine());
        int mask = 1 << index;
        int bitAtIndex = (number & mask) >> index;
        Console.Write("The bit at index {0} is: ",index);
        Console.WriteLine(bitAtIndex);
    }
}
