//Problem 1. StringBuilder.Substring

//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace SBSubstring
{
    using System;
    using System.Text;
    using ExtensionMethods;

    class StringBuilderSub
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            text.Append("This is a random text to test the extension method!");

            Console.WriteLine(text + "\n");

            text.Substring(10, 11);

            Console.WriteLine("After applying the substing extension method:");
            Console.WriteLine(text + "\n");
        }
    }
}
