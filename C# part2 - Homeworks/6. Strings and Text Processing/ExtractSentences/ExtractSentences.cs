//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string searchedWord = " in ";
        int sentenceEndIndex = new int();
        int searchedWordIndex = new int();
        StringBuilder sentences = new StringBuilder();
        StringBuilder modifyInput = new StringBuilder();
        modifyInput.Append(input);

        while (true)
        {
            searchedWordIndex = modifyInput.ToString().IndexOf(searchedWord);
            sentenceEndIndex = modifyInput.ToString().IndexOf(".");
            if (sentenceEndIndex > searchedWordIndex && searchedWordIndex >= 0)
            {
                        sentences.Append(modifyInput.ToString().Substring(0, sentenceEndIndex + 1));
            }
            else if (searchedWordIndex < 0)
            {
                break;
            }
            modifyInput.Remove(0, sentenceEndIndex + 1);
        }
        Console.WriteLine(sentences.ToString().Trim());
    }
}
