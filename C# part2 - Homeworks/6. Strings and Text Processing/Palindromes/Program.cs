//Problem 20. Palindromes

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter string:");
            string input = Console.ReadLine();
            List<string> Palindromes = new List<string>();
            Palindromes = WordCombinations(input);

            Console.WriteLine("\nList of palindromes in sentence:");
            foreach (string palindrome in Palindromes)
            {
                Console.WriteLine(palindrome);
            }
        }

        static List<string> WordCombinations(string input)
        {
            string[] words = input.Split(new char[] { ',', '.', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string currentPhrase = string.Empty;
            int startWordIndex = new int();
            int searchEndWord = new int();
            int endWordIndex = new int();
            int endWordCount = new int();
            bool isPalindrome = new bool();
            List<string> Palindromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                searchEndWord = 0;
                startWordIndex = input.IndexOf(words[i]);
                if (startWordIndex > 0)
                {
                    while (IsLetter(input[startWordIndex - 1]) && IsLetter(input[startWordIndex + words[i].Length + 1]))
                    {
                        searchEndWord = startWordIndex + 1;
                        startWordIndex = input.IndexOf(words[i], searchEndWord);
                    }
                }

                searchEndWord = 0;
                endWordCount = i;

                while (endWordCount < words.Length)
                {
                    endWordIndex = input.IndexOf(words[endWordCount], searchEndWord);
                    if (endWordIndex > 0)
                    {
                        while (IsLetter(input[endWordIndex - 1]) && IsLetter(input[endWordIndex + words[endWordCount].Length + 1]))
                        {
                            searchEndWord = endWordIndex + 1;
                            endWordIndex = input.IndexOf(words[endWordCount], searchEndWord);
                        }
                    }
                    currentPhrase = input.Substring(startWordIndex, endWordIndex - startWordIndex + words[endWordCount].Length);
                    isPalindrome = IsPalindrome(currentPhrase);

                    if (isPalindrome)
                    {
                        Palindromes.Add(currentPhrase);
                    }
                    endWordCount++;
                }
            }
            return Palindromes;
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

        public static bool IsPalindrome(string value)
        {
            if (value.Length < 3)
            {
                return false;
            }
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];

                // Scan forward for a while invalid.
                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    a = value[min];
                }

                // Scan backward for b while invalid.
                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    b = value[max];
                }

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
