//Problem 9. Delete odd lines

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader input = new StreamReader(@"..\..\input.txt");
        string line = input.ReadLine();
        List<string> lines = new List<string>();
        int lineNumber = 1;

        while (line != null)
        {
            if (lineNumber % 2 == 0)
            {
                lines.Add(line);
            }

            line = input.ReadLine();
            lineNumber++;
        }

        input.Close();

        using (StreamWriter output = new StreamWriter(@"..\..\input.txt"))
        {
            foreach (string evenLine in lines)
            {
                output.WriteLine(evenLine);
            }
            output.Flush();
        }

        Console.WriteLine("All odds lines were deleted.\n\nResult:");

        using (StreamReader print = new StreamReader(@"..\..\input.txt"))
        {
            Console.WriteLine(print.ReadToEnd());
        }
    }
}
