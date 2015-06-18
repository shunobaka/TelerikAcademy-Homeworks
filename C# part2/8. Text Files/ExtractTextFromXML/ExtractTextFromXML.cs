//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

using System;
using System.IO;
using System.Text;

class ExtractTextFromXML
{
    static void Main()
    {
        string input = string.Empty;

        using (StreamReader XML = new StreamReader(@"..\..\input.txt"))
        {
            input = XML.ReadToEnd();
        }

        int tagStartIndex = new int();
        int tagEndIndex = new int();
        string title = string.Empty;
        StringBuilder text = new StringBuilder();
        text.Append(input);

        while (true)
        {
            tagStartIndex = text.ToString().IndexOf("<");
            tagEndIndex = text.ToString().IndexOf(">");

            if (tagStartIndex >= 0 && tagEndIndex >= 0)
            {
                text.Remove(tagStartIndex, tagEndIndex - tagStartIndex + 1);
                if (tagStartIndex != 0 && text.ToString()[tagStartIndex - 1] != ' ')
                {
                    text.Insert(tagStartIndex, ' ');
                }
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Result text:");
        Console.WriteLine(text.ToString().Trim());

        Console.WriteLine("\nSaving text in output.txt");
        using (StreamWriter XMLOutput = new StreamWriter(@"..\..\output.txt"))
        {
            XMLOutput.Write(text.ToString().Trim());
        }
    }
}
