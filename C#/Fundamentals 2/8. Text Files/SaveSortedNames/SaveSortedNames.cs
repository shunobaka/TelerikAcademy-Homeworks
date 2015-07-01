//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	    output.txt
//Ivan          George
//Peter         Ivan
//Maria         Maria
//George        Peter

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        List<string> names = new List<string>();

        Console.WriteLine("Input:");
        using (StreamReader text = new StreamReader(@"..\..\input.txt"))
        {
            string line = text.ReadLine();
            while (line != null)
            {
                names.Add(line);
                Console.WriteLine(line);
                line = text.ReadLine();
            }
        }

        names.Sort();

        using (StreamWriter text = new StreamWriter(@"..\..\output.txt"))
        {
            foreach (string name in names)
            {
                text.WriteLine(name);
            }
        }

        Console.WriteLine("\nNames are sorted and saved in output.txt\n\nResult:");

        using (StreamReader text = new StreamReader(@"..\..\output.txt"))
        {
            Console.WriteLine(text.ReadToEnd());
        }
    }
}
