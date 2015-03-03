//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        StreamReader input = new StreamReader(@"..\..\input.txt");
        StreamWriter output = new StreamWriter(@"..\..\output.txt");
        string line = input.ReadLine();
        int lineNumber = 1;

        while (line != null)
        {
            line = line.Insert(0,lineNumber.ToString() + ". ");
            output.WriteLine(line);
            line = input.ReadLine();
            lineNumber++;
        }
        Console.WriteLine("Line numbers added.\nChanges saved in output.txt.\n\nResult:");
        output.Flush();
        input.Close();
        output.Close();

        using (StreamReader readOutput = new StreamReader(@"..\..\output.txt"))
        {
            Console.WriteLine(readOutput.ReadToEnd());
        }
    }
}
