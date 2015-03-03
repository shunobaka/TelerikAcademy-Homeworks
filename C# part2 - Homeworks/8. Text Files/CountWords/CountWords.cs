//Problem 13. Count words

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class CountWords
{
    static void Main()
    {
        int length = ObtainNumberOfWords();
        int[] count = new int[length];
        string[] words = new string[length];
        string text = GetText();

        words = ObtainWords(length);
        count = CountWordsInText(count, words, text);
        try
        {
            Array.Sort(count, words);
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("The arrays cannot be sorted!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The array is empty!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Array.Sort cannot sort this argument!");
        }

        CreateOutput(count, words);
    }

    static void CreateOutput(int[] count, string[] words)
    {
        try
        {
            using (StreamWriter output = new StreamWriter(@"..\..\output.txt"))
            {
                for (int i = count.Length - 1; i >= 0; i--)
                {
                    output.WriteLine("{0, -10} - {1}", words[i], count[i]);
                }
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Could not access the file!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory was not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occured!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("One or both of the arrays are null!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file could not be read!");
        }
    }

    static string GetText()
    {
        string text = string.Empty;
        try
        {
            using (StreamReader input = new StreamReader(@"..\..\input.txt"))
            {
                text = input.ReadToEnd();
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The input text was not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory of the input text was not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occured!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file could not be read!");
        }

        return text;
    }

    static string[] ObtainWords(int length)
    {
        string[] words = new string[length];
        int index = 0;
        try
        {
            using (StreamReader wordsList = new StreamReader(@"..\..\words.txt"))
            {
                string word = wordsList.ReadLine();
                while (word != null)
                {
                    words[index] = word;
                    index++;
                    word = wordsList.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The input text was not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory of the input text was not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occured!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file could not be read!");
        }

        return words;
    }

    static int ObtainNumberOfWords()
    {
        int numberOfWords = 0;
        try
        {
            using (StreamReader wordsList = new StreamReader(@"..\..\words.txt"))
            {
                string word = wordsList.ReadLine();

                while (word != null)
                {
                    numberOfWords++;
                    word = wordsList.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The input text was not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory of the input text was not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occured!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file could not be read!");
        }

        return numberOfWords;
    }

    static int[] CountWordsInText(int[] count, string[] words, string text)
    {
        int currentWordCount = 0;
        int startIndex = 0;
        try
        {
            for (int i = 0; i < count.Length; i++)
            {
                currentWordCount = 0;
                startIndex = 0;

                startIndex = text.IndexOf(words[i]);

                while (startIndex != -1)
                {
                    currentWordCount++;
                    startIndex = text.IndexOf(words[i], startIndex + 1);
                }

                count[i] = currentWordCount;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The loop went outside of arrays length.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The arrays is null.");
        }
        return count;
    }
}
