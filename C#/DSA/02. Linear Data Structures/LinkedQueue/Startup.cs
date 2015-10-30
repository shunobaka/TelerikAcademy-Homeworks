// 13. Implement the ADT queue as dynamic linked list.

// Use generics (LinkedQueue<T>) to allow storing different data types in the queue.

namespace LinkedQueue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();

            for (int i = 0; i < 15; i++)
            {
                queue.Enqueue(i + 1);
            }

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
