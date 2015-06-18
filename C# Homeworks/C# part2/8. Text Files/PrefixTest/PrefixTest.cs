//Problem 11. Prefix "test"

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Collections.Generic;
using System.IO;

class PrefixTest
{
    static void Main()
    {
        string text = GetInput();
        string[] words = text.Trim().Split(new char[] {' ', ',','.','!','-'}, StringSplitOptions.RemoveEmptyEntries);
        string result = FindWordsAndRemove(text, words);
        string[] resultWords = result.Trim().Split(new char[] {' ', ',','.','!','-'}, StringSplitOptions.RemoveEmptyEntries);
        result = string.Join(" ",resultWords);
        UpdateInputFile(result);

        Console.WriteLine("Before update:\n{0}", text);
        Console.WriteLine("\nAfter update:\n{0}",result);
        Console.WriteLine("\nChanges saved in same file.");
    }

    static void UpdateInputFile(string result)
    {
        using (StreamWriter update = new StreamWriter(@"..\..\input.txt"))
        {
            update.WriteLine(result);
        }
    }

    static string FindWordsAndRemove(string text, string[] words)
    {
        string currentWord = string.Empty;
        bool validWord = true;

        for (int i = 0; i < words.Length; i++)
        {
            currentWord = words[i];
            validWord = true;
            if (currentWord.Length > 4)
            {
                if (currentWord.Substring(0, 4) == "test")
                {
                    foreach (char symbol in currentWord)
                    {
                        if (IsInvalidChar(symbol))
                        {
                            validWord = false;
                        }
                    }

                    if (validWord)
                    {
                        text = text.Replace(currentWord, string.Empty);
                    }
                }
            }
        }

        return text;
    }

    static bool IsInvalidChar(char symbol)
    {
        if ((symbol < 'a' || symbol > 'z') && (symbol < 'A' || symbol > 'Z') && (symbol < '0' || symbol > '9') && (symbol != '_'))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static string GetInput()
    {
        string text = string.Empty;

        using (StreamReader input = new StreamReader(@"..\..\input.txt"))
        {
            text = input.ReadToEnd();
        }

        return text;
    }
}

