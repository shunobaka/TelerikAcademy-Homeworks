//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        int startIndex = new int();
        int endIndex = new int();
        StringBuilder inputChange = new StringBuilder();
        StringBuilder textToChange = new StringBuilder();

        inputChange.Append(input);
        while (true)
        {
            startIndex = inputChange.ToString().IndexOf("<upcase>");
            endIndex = inputChange.ToString().IndexOf("</upcase>");

            if (startIndex >= 0 && endIndex >= 0)
            {
                textToChange.Append(inputChange.ToString().Substring(startIndex + 8, endIndex - startIndex - 8));
                inputChange.Remove(startIndex, endIndex + 9 - startIndex);
                inputChange.Insert(startIndex, textToChange.ToString().ToUpper());
                textToChange.Clear();
            }
            else 
            {
                break;
            }
        }
        Console.WriteLine(inputChange.ToString());
    }
}

