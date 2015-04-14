//Problem 5. 64 Bit array

//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace SixtyFourBitArray
{
    using System;

    class BitArrayTest
    {
        static void Main()
        {
            BitArray64 numOne = new BitArray64(43554534);
            BitArray64 numTwo = new BitArray64(5453545354);
            BitArray64 numThree = new BitArray64(43554534);

            Console.WriteLine(numOne == numTwo);
            Console.WriteLine(numOne == numThree);
            Console.WriteLine(numOne != numThree);

            foreach (var bit in numOne)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            numOne[62] = 1;

            foreach (var bit in numOne)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Console.WriteLine(numTwo.GetHashCode());
        }
    }
}
