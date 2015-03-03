//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader textOne = new StreamReader(@"..\..\textOne.txt");
        StreamReader textTwo = new StreamReader(@"..\..\textTwo.txt");
        StreamWriter resultFile = new StreamWriter(@"..\..\result.txt");
        string text1 = textOne.ReadToEnd();
        string text2 = textTwo.ReadToEnd();

        textOne.Close();
        textTwo.Close();

        string result = text1 + text2;
        Console.WriteLine("Textes concatenated and saved in result.txt");
        Console.WriteLine("\n{0}", result);

        resultFile.Write(result);
        resultFile.Flush();
        resultFile.Close();

    }
}

