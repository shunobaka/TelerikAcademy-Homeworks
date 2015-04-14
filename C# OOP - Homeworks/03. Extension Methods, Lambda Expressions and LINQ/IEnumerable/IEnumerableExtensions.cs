//Problem 2. IEnumerable extensions

//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace IEnumerableExt
{
    using System;
    using ExtensionMethods;
    using System.Collections.Generic;

    class IEnumerableExtensions
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(15);
            list.Add(11);

            Console.WriteLine("Numbers: {0}\n", string.Join(", ", list));
            Console.WriteLine("Sum: {0}", list.Sum());
            Console.WriteLine("Product: {0}", list.Product());
            Console.WriteLine("Average: {0:F2}", list.Average());
            Console.WriteLine("Min: {0}", list.Min());
            Console.WriteLine("Max: {0}", list.Max());
        }
    }
}
