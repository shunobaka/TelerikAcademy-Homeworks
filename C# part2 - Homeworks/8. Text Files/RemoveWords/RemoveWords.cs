//Problem 12. Remove words

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Collections.Generic;

class RemoveWords
{
    static void Main()
    {
        List<string> wordsList = new List<string>();

        string text = ReadInputText();

        Console.WriteLine("Text before removing:\n{0}",text);

        wordsList = MakeListOfWords();
        text = RemoveWordsFromText(wordsList, text);
        string[] result = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        SaveChanges(result);


        Console.WriteLine("\nText after removing:\n{0}\n", string.Join(" ", result));
    }

    static List<string> MakeListOfWords()
    {
        List<string> wordsList = new List<string>();
        try
        {
            using (StreamReader readWords = new StreamReader(@"..\..\ListOfWords.txt"))
            {
                string word = readWords.ReadLine();

                while (word != null)
                {
                    wordsList.Add(word);
                    word = readWords.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The list of words was not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory of the list with words was not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occured!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file could not be read!");
        }
        return wordsList;
    }

    static string ReadInputText()
    {
        string text = string.Empty;
        try
        {
            using (StreamReader readInput = new StreamReader(@"..\..\input.txt"))
            {
                text = readInput.ReadToEnd();
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

    static string RemoveWordsFromText(List<string> wordsList, string text)
    {
        try
        {
            foreach (string word in wordsList)
            {
                text = text.Replace(word, string.Empty);
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Word not found in text.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The action could not be complete");
        }

        return text;
    }

    static void SaveChanges(string[] result)
    {
        try
        {
            using (StreamWriter saveChanges = new StreamWriter(@"..\..\input.txt"))
            {
                saveChanges.Write(string.Join(" ", result));
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Could not access the file!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory of the input text was not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occured!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The result string is null!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file could not be read!");
        }
    }
}