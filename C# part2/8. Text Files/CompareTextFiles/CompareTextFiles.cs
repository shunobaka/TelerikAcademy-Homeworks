//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        StreamReader textOne = new StreamReader(@"..\..\textOne.txt");
        StreamReader textTwo = new StreamReader(@"..\..\textTwo.txt");
        string lineInTextOne = textOne.ReadLine();
        string lineInTextTwo = textTwo.ReadLine();
        int numberOfSameLines = new int();
        int numberOfDiffLines = new int();

        while (lineInTextOne != null && lineInTextTwo != null)
        {
            if (lineInTextOne == lineInTextTwo)
            {
                numberOfSameLines++;
            }
            else
            {
                numberOfDiffLines++;
            }

            lineInTextOne = textOne.ReadLine();
            lineInTextTwo = textTwo.ReadLine();
        }

        textOne.Close();
        textTwo.Close();

        Console.WriteLine("There are {0} lines which are the same.",numberOfSameLines);
        Console.WriteLine("{0} of the lines are different.",numberOfDiffLines);
    }
}
