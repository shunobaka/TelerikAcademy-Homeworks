// 12. Implement the ADT stack as auto-resizable array.

// Resize the capacity on demand (when no space is available to add / insert a new element).

namespace CustomStack
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var stack = new CustomStack<int>();

            for (int i = 0; i < 15; i++)
            {
                stack.Push(i + 1);
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
