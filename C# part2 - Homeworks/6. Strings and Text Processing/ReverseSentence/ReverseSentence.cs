//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.
//Example:

//input:
//C# is not C++, not PHP and not Delphi!

//output:
//Delphi not and PHP, not C++ not is C#!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReverseSentence
    {
        static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            string result = ReverseWords(input);

            Console.WriteLine("Initial text:\n{0}", input);
            Console.WriteLine("\nResult text:\n{0}\n", result);
        }

        static string ReverseWords(string input)
        {
            string[] wordsInInput = input.Split(new char[] { ' ', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder inputBuild = new StringBuilder();
            int startIndex = new int();
            int indexOfWord = new int();

            inputBuild.Append(input);

            for (int i = 0; i < wordsInInput.Length; i++)
            {
                indexOfWord = inputBuild.ToString().IndexOf(wordsInInput[i], startIndex);
                inputBuild.Remove(indexOfWord, wordsInInput[i].Length);
                inputBuild.Insert(indexOfWord, wordsInInput[wordsInInput.Length - 1 - i]);
                startIndex = indexOfWord + wordsInInput[wordsInInput.Length - 1 - i].Length;
            }

            return inputBuild.ToString();
        }
    }
