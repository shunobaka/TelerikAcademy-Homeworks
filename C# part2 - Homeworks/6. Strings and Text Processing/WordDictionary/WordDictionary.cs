//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input     |   output
//.NET      |   platform for applications from Microsoft
//CLR	    |   managed execution environment for .NET
//namespace |   hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordDictionary
{
    static void Main()
    {
        string[] dictionary = { ".NET platform for applications from Microsoft",
                              "CLR managed execution environment for .NET",
                              "namespace hierarchical organization of classes"};
        string currentLine = string.Empty;
        int wordEnd = new int();

        Console.WriteLine("List of words:");
        for (int i = 0; i < dictionary.Length; i++)
        {
            wordEnd = dictionary[i].IndexOf(" ");
            Console.WriteLine(dictionary[i].Substring(0, wordEnd));
        }

        Console.WriteLine("\nEnter word:");
        string input = Console.ReadLine();

        for (int i = 0; i < dictionary.Length; i++)
        {
            currentLine = dictionary[i];
            wordEnd = currentLine.IndexOf(" ");
            if (input == currentLine.Substring(0, wordEnd))
            {
                Console.WriteLine("\nDefinition:\n{0}\n", currentLine.Substring(wordEnd + 1));
                break;
            }
        }
    }
}
