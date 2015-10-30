// 10. We are given numbers N and M and the following operations:
   
// N = N+1
// N = N+2
// N = N*2
   
// Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
   
// Hint: use a queue.
// Example: N = 5, M = 16
// Sequence: 5 → 7 → 8 → 16

namespace ShortestOperationSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        private const int start = 2;
        private const int end = 25;

        public static void Main()
        {
            // I think with a stack is easier to implement by starting from the end :)

            Stack<Operation> operations = GetOperations(start, end);
            PrintSteps(operations, start);
        }

        private static void PrintSteps(Stack<Operation> operations, int start)
        {
            Console.WriteLine("The shortest sequence is:");
            Console.Write(start);

            while (operations.Count > 0)
            {
                var operation = operations.Pop();

                switch (operation)
                {
                    case Operation.PlusOne:
                        start++;
                        break;
                    case Operation.PlusTwo:
                        start += 2;
                        break;
                    case Operation.Double:
                        start *= 2;
                        break;
                    default:
                        break;
                }

                Console.Write(" -> {0}", start);
            }

            Console.WriteLine();
        }

        private static Stack<Operation> GetOperations(int start, int end)
        {
            Stack<Operation> operations = new Stack<Operation>();

            while (end > start)
            {
                if ((end % 2 == 0) && (end / 2 >= start))
                {
                    end /= 2;
                    operations.Push(Operation.Double);
                }
                else if ((end - 1 >= start) && (end % 2 == 1))
                {
                    end--;
                    operations.Push(Operation.PlusOne);
                }
                else if (end - 2 >= start)
                {
                    end -= 2;
                    operations.Push(Operation.PlusTwo);
                }
                else if (end - 1 >= start)
                {
                    end--;
                    operations.Push(Operation.PlusOne);
                }
            }

            return operations;
        }
    }
}
