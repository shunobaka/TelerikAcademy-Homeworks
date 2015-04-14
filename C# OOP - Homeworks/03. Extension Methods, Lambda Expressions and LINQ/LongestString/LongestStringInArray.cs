//Problem 17. Longest string

//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

namespace LongestString
{
    using System;
    using System.Linq;

    class LongestStringInArray
    {
        static void Main()
        {
            var strings = new string[]
            {
                "this is a string",
                "this is the longest string in the array",
                "just some not so long string",
                "short string",
                "this is a pretty long string"
            };

            var longestString = (from x in strings
                                 orderby x.Length descending
                                 select x)
                                 .ToList()
                                 .FirstOrDefault();

            Console.WriteLine(longestString);
        }
    }
}
