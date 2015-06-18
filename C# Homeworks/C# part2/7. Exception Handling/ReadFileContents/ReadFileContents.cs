//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Text;

class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("Please enter file name with path to it:");
        string file = Console.ReadLine();
        try
        {
            using (StreamReader text = new StreamReader(file, Encoding.UTF8))
            {
                string content = text.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("There was an error finding the file. Please check name for mistakes.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory of the file was not found. Please check input.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This file cannot be read.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Please enter path.");
        }
    }
}
