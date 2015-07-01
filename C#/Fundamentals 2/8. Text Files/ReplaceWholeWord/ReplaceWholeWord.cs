//Problem 8. Replace whole word

//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        string text = string.Empty;
        int startIndex = new int();

        using (StreamReader input = new StreamReader(@"..\..\input.txt"))
        {
            text = input.ReadToEnd();
        }

        startIndex = text.ToLower().IndexOf("start");
        while (startIndex > 0)
        {
            if (!IsLetter(text.ToString()[startIndex - 1]) && !IsLetter(text.ToString()[startIndex + 5]))
            {
                text = text.Remove(startIndex, 5).Insert(startIndex, "finish");
            }
            startIndex = text.ToLower().IndexOf("start",startIndex + 1);
        }

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

    static bool IsLetter(char symbol)
    {
        if ((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z'))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
