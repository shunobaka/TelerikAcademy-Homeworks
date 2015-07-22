namespace LoopRefactoring
{
    using System;

    public class RefactoredLoop
    {
        public static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
