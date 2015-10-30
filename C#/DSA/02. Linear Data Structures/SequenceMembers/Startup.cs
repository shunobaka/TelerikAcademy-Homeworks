// 09. We are given the following sequence:
   
// S1 = N;
// S2 = S1 + 1;
// S3 = 2*S1 + 1;
// S4 = S1 + 2;
// S5 = S2 + 1;
// S6 = 2*S2 + 1;
// S7 = S2 + 2;
// ...
// Using the Queue<T> class write a program to print its first 50 members for given N.
// Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

namespace SequenceMembers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private const int StartNumber = 2;

        public static void Main()
        {
            var numbersQueue = new Queue<int>();
            var counter = 0;

            numbersQueue.Enqueue(StartNumber);

            while (counter < 50)
            {
                var number = numbersQueue.Dequeue();
                Console.WriteLine("Number {0}: {1}", counter + 1, number);
                counter++;

                numbersQueue.Enqueue(number + 1);
                numbersQueue.Enqueue(2 * number + 1);
                numbersQueue.Enqueue(number + 2);
            }
        }
    }
}
