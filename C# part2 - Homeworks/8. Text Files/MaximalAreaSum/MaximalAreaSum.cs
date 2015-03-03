//Problem 5. Maximal area sum

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:

//input	     output
//4          17
//2 3 3 4 
//0 2 3 4 
//3 7 1 2 
//4 3 3 2

using System;
using System.Linq;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        StreamReader input = new StreamReader(@"..\..\input.txt");
        string line = input.ReadLine();
        int size = int.Parse(line);
        int[,] matrix = new int[size, size];
        int sum = new int();
        int maxSum = new int();

        for (int i = 0; i < size; i++)
        {
            line = input.ReadLine();
            string[] lineNumber = line.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int j = 0; j < size; j++)
            {
                matrix[j, i] = int.Parse(lineNumber[j]);
            }
        }

        input.Close();

        for (int i = 0; i < size - 1; i++)
        {
            for (int j = 0; j < size - 1; j++)
            {
                sum = matrix[j, i] + matrix[j + 1, i] + matrix[j, i + 1] + matrix[j + 1, i + 1];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        using (StreamWriter output = new StreamWriter(@"..\..\output.txt"))
        {
            output.WriteLine(maxSum);
        }

        Console.WriteLine("Max sum found and stored in output.txt");
    }
}
