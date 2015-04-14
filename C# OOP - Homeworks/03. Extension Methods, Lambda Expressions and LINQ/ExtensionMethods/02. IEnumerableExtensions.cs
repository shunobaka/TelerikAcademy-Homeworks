namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static double Average<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            dynamic sum = 0;
            double itemCount = 0;

            foreach (var item in collection)
            {
                sum += item;
                itemCount++;
            }

            double average = sum / itemCount;

            return average;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            T min = collection.First();

            foreach (var item in collection)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            T max = collection.First();

            foreach (var item in collection)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}
