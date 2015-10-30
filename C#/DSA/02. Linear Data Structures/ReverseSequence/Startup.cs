// 02. Write a program that reads N integers from the console and reverses them using a stack.

// Use the Stack<int> class.

namespace ReverseSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter amount of numbers:");

            int count = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                numbers.Push(int.Parse(input));
            }

            Console.WriteLine("The reversed sequence:");

            while (numbers.Count != 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
