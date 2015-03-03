//Problem 22. Words count

//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string[] allWords = input.Trim().ToLower().Split(new char[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> words = new List<string>();

        foreach (string word in allWords)
        {
            if (words.IndexOf(word) == (-1))
            {
                words.Add(word.ToLower());
            }
        }

        foreach (string word in words)
        {
            int counter = 0;
            foreach (string wordInSentense in allWords)
            {
                if (word == wordInSentense)
                {
                    counter++;
                }
            }
            if (counter == 1)
            {
                Console.WriteLine("{0, -10} - {1} time", word, counter);
            }
            else
            {
                Console.WriteLine("{0, -10} - {1} times", word, counter);
            }
        }
    }
}
