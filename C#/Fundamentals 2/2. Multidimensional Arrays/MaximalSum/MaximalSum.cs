//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

//Example for matrix 5x5:

//Input:       | Output:
// 1 2 3 4 1   | 2 3 4
// 1 4 6 6 1   | 4 6 6
// 1 4 4 2 1   | 4 4 2
// 1 1 1 1 1   |
// 1 1 1 1 1   | The sum is: 35 

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter length of matrix: ");
        int lenght = int.Parse(Console.ReadLine());
        Console.Write("Enter height of matrix: ");
        int height = int.Parse(Console.ReadLine());
        int[,] matrix = new int[lenght, height];
        int sum = 0;
        int topSum = 0;
        int[,] topSumMatrix = new int[3, 3];

        Console.WriteLine("Enter the matrix (elements separated by space):");
//Fills matrix
        for (int heightCount = 0; heightCount < height; heightCount++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            for (int lengthCount = 0; lengthCount < lenght; lengthCount++)
            {
                matrix[lengthCount, heightCount] = int.Parse(input[lengthCount]);
            }
        }
//Checks sums
        for (int i = 1; i < height - 1; i++)
        {
            for (int j = 1; j < lenght - 1; j++)
            {
                sum = matrix[j - 1, i - 1] + matrix[j, i - 1] + matrix[j + 1, i - 1] 
                    + matrix[j - 1, i] + matrix[j, i] + matrix[j + 1, i] 
                    + matrix[j - 1, i + 1] + matrix[j, i + 1] + matrix[j + 1, i + 1];

                if (sum > topSum)
                {
                    topSum = sum;
                    topSumMatrix[0, 0] = matrix[j - 1, i - 1];
                    topSumMatrix[1, 0] = matrix[j, i - 1];
                    topSumMatrix[2, 0] = matrix[j + 1, i - 1];
                    topSumMatrix[0, 1] = matrix[j - 1, i];
                    topSumMatrix[1, 1] = matrix[j, i];
                    topSumMatrix[2, 1] = matrix[j + 1, i];
                    topSumMatrix[0, 2] = matrix[j - 1, i + 1];
                    topSumMatrix[1, 2] = matrix[j, i + 1];
                    topSumMatrix[2, 2] = matrix[j + 1, i + 1];
                }
            }
        }
        Console.WriteLine();
//Print
        Console.WriteLine("The 3x3 square with highest sum is:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(topSumMatrix[j,i] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("The sum is: {0}",topSum);
    }
}
