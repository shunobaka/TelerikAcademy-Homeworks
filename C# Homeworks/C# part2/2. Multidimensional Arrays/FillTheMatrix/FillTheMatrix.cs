//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

//Example for n=4:
// a:                   b:                      c:
//1  5	9	13          1	8	9	16          7	11	14	16
//2  6	10	14          2	7	10	15          4	8	12	15
//3  7	11	15          3	6	11	14          2	5	9	13
//4  8	12	16          4	5	12	13          1	3	6	10

using System;
using System.Collections.Generic;
using System.Linq;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter size of matrix: ");
        int size = int.Parse(Console.ReadLine());
        int counter = 1;
        int countY = 0;
        int countX = 0;

        int[,] matrixA = new int[size, size];
        int[,] matrixB = new int[size, size];
        int[,] matrixC = new int[size, size];
//Matrix A
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                matrixA[row, col] = counter;
                counter++;
            }
        }
        counter = 1;
//Matrix B
        for (int row = 0; row < size; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < size; col++)
                {
                    matrixB[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int col = size - 1; col >= 0; col--)
                {
                    matrixB[row, col] = counter;
                    counter++;
                }
            }
        }
        counter = 1;
//Matrix C
        for (int row = size - 1; row >= 0; row--)
        {
            countY = row;
            countX = 0;
            while (countY < size)
            {
                matrixC[countX, countY] = counter;
                counter++;
                countX++;
                countY++;
            }
        }
        for (int col = 1; col < size; col++)
        {
            countY = 0;
            countX = col;
            while (countX < size)
            {
                matrixC[countX, countY] = counter;
                counter++;
                countX++;
                countY++;
            }
        }
//Print A
        Console.WriteLine("Matrix A:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrixA[j, i].ToString().PadRight(3) + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
//Print B
        Console.WriteLine("Matrix B:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrixB[j, i].ToString().PadRight(3) + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
//Print C
        Console.WriteLine("Matrix C:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrixC[j, i].ToString().PadRight(3) + " ");
            }
            Console.WriteLine();
        }
    }
}
