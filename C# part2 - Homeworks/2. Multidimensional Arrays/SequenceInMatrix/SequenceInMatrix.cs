//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

//Example:

// Matrix:    | Result:   | Matrix2:       | Result2: 
//            |           |                | 
//  s, qq, s  | s, s, s   | ha,fifi,ho,hi  | ha, ha, ha
// pp, pp, s  |           | fo,ha,hi,xx    |
// pp, qq, s  |           | xxx,ho,ha,xx   |

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceInMatrix
{
    static void Main()
    {
        Console.Write("Enter height of matrix: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Enter width of matrix: ");
        int width = int.Parse(Console.ReadLine());
        string[,] matrix = new string[height, width];
        string bestWord = string.Empty;
        int bestCount = new int();
        int nextCol = new int();
        int nextRow = new int();
        string result = string.Empty;
        int count = new int();
//Fill Matrix 
        Console.WriteLine("Enter elements of matrix separated by comma:");
        for (int row = 0; row < height; row++)
        {
            string[] inputLine = Console.ReadLine().Trim().Split(',').ToArray();
            for (int widthCount = 0; widthCount < width; widthCount++)
            {
                matrix[row, widthCount] = inputLine[widthCount];
            }
        }
//Check sequence
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                count = 0;
                nextCol = col;
                nextRow = row;
                while (nextCol < width && matrix[row, col] == matrix[row, nextCol])
                {
                    count++;
                    nextCol++;
                }
                nextCol = col;
                if (count > bestCount)
                {
                    bestCount = count;
                    bestWord = matrix[row, col];
                }
                count = 0;
                while (nextRow < height && matrix[row, col] == matrix[nextRow, col])
                {
                    count++; 
                    nextRow++;
                }
                nextRow = row;
                if (count > bestCount)
                {
                    bestCount = count;
                    bestWord = matrix[row, col];
                }
                count = 0;
                while (nextRow < height && nextCol < width && matrix[row, col] == matrix[nextRow, nextCol])
                {
                    count++;
                    nextCol++;
                    nextRow++;
                }
                nextRow = row;
                nextCol = col;
                if (count > bestCount)
                {
                    bestCount = count;
                    bestWord = matrix[row, col];
                }
                count = 0;
                while ((nextRow >= 0 && nextCol >= 0 && matrix[row, col] == matrix[nextRow, nextCol]))
                {
                    count++;
                    nextCol--;
                    nextRow--;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestWord = matrix[row, col];
                }
            }
        }
//Print the sequence
        for (int counter = 0; counter < bestCount; counter++)
	    {
            result += bestWord;
            if (counter != bestCount - 1)
            {
                result += ",";
            }
		}
        Console.WriteLine("The result is:");
        result = result.Replace("\t", " ").Replace(" ", "").Replace(",", ", "); ;
        Console.WriteLine(result);
    }
}
