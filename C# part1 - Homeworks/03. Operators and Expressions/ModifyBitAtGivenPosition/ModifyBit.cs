//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter index to modify: ");
        int index = int.Parse(Console.ReadLine());
        Console.Write("Enter what bit to modify to: ");
        byte bit = byte.Parse(Console.ReadLine());
        while (bit < 0 || bit > 1)
        {
            Console.WriteLine("Invalid input for bit!");
            Console.Write("Enter what bit to modify to: ");
            bit = byte.Parse(Console.ReadLine());
        }
        int mask = 1 << index;
        int result = new int();

        if (bit == 1)
        {
            result = number | mask;
            Console.WriteLine(result);
        }
        else
        {
            result = ~number | mask;
            Console.WriteLine(~result);
        }
    }
}
