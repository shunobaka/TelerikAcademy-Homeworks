//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        string text = string.Empty;

        using (StreamReader input = new StreamReader(@"..\..\input.txt"))
        {
            text = input.ReadToEnd();
        }

        text = text.Replace("start", "finish");

        Console.WriteLine("After replacement:");
        Console.WriteLine(text);

        using (StreamWriter output = new StreamWriter(@"..\..\input.txt"))
        {
            output.Write(text);
        }

        Console.WriteLine("\nAll \"start\" replaced with \"finish\"\nResult saved in same file.\n\nResult:");

        using (StreamReader input = new StreamReader(@"..\..\input.txt"))
        {
            Console.WriteLine(input.ReadToEnd());
        }
    }
}
