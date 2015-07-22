namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public class SearchingAlgorithms
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null");
            Debug.Assert(value != null, "The searched value is null");
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Start index is out of array's range");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "End index is out of array's range");
            Debug.Assert(startIndex <= endIndex, "The start index is greater than end index");
            Debug.Assert(AssertionUtils.IsSorted(arr), "The array is not sorted");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    endIndex = midIndex - 1;
                }
            }

            Debug.Assert(!AssertionUtils.HasValue(arr, value), "The array contains the searched value");
            return -1;
        }
    }
}
