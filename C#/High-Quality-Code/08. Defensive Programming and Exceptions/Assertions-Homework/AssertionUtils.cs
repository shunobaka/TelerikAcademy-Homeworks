namespace Assertions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AssertionUtils
    {
        public static bool IsSorted<T>(IEnumerable<T> list) where T : IComparable<T>
        {
            if (list.Count() > 0)
            {
                var previousElement = list.First();
                return list.Skip(1).All(currentElement =>
                {
                    bool isGreaterThanLast = previousElement.CompareTo(currentElement) < 0;
                    previousElement = currentElement;
                    return isGreaterThanLast;
                });
            }
            else
            {
                return true;
            }
        }

        public static bool HasValue<T>(IEnumerable<T> list, T value) where T : IComparable<T>
        {
            return list.Any(x => x.Equals(value));
        }

        public static bool IsMinValue<T>(IEnumerable<T> list, T value, int starInd, int endInd) where T : IComparable<T>
        {
            return list.Skip(starInd)
                .Take(endInd - starInd)
                .Min()
                .CompareTo(value) > -1;
        }
    }
}
