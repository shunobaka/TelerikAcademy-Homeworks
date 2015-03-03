//Problem 9. Forbidden words

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = "PHP, CLR, Microsoft".Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine(input);
        Console.WriteLine("\nForbidden words: {0}", string.Join(", ", forbiddenWords));
        Console.WriteLine("\nThe modified text:");
        Console.WriteLine(ReplaceWords(input,forbiddenWords));
    }

    static string ReplaceWords(string input, string[] forbiddenList)
    {
        StringBuilder result = new StringBuilder();
        result.Append(input);

        for (int i = 0; i < forbiddenList.Length; i++)
        {
            result.Replace(forbiddenList[i], new string('*', forbiddenList[i].Length));
        }

        return result.ToString();
    }
}
