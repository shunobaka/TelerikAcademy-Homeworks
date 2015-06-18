//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\Test text file.txt"))
        {
            string line = reader.ReadLine();
            int counter = 1;

            while (line != null)
            {
                if (counter % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                counter++;
                line = reader.ReadLine();
            }
        }
    }
}
