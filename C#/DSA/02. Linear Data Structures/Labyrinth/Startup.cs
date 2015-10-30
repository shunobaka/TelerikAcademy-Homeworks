// (*) We are given a labyrinth of size N x N.
   
// Some of its cells are empty (0) and some are full(x).
// We can move from an empty cell to another empty cell if they share common wall.
// Given a starting position (*) calculate and fill in the array the minimal distance 
// from this position to any other cell in the array. Use "u" for all unreachable cells.

namespace Labyrinth
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static string[,] inputLabirinth =
        {
            { "0", "0", "0", "X", "0", "X" },
            { "0", "X", "0", "X", "0", "X" },
            { "0", "*", "X", "0", "X", "0" },
            { "0", "X", "0", "0", "0", "0" },
            { "0", "0", "0", "X", "X", "0" },
            { "0", "0", "0", "X", "0", "X" }
        };

        public static void Main()
        {
            var startingCell = FindStartingCell();
            string[,] outputLabyright = new string[inputLabirinth.GetLength(0), inputLabirinth.GetLength(1)];
            FillOutputLabyrinth(startingCell, outputLabyright);
            PrintOutputLabyrinth(outputLabyright);
        }

        public static void FillOutputLabyrinth(Cell startingCell, string[,] outputLabyrinth)
        {
            bool[,] isUsed = new bool[inputLabirinth.GetLength(0), inputLabirinth.GetLength(1)];

            var queue = new Queue<Cell>();

            queue.Enqueue(startingCell);
            isUsed[startingCell.Row, startingCell.Column] = true;
            outputLabyrinth[startingCell.Row, startingCell.Column] = "*";

            while (queue.Count > 0)
            {
                var cell = queue.Dequeue();

                // Check and enqueue left cell
                if (cell.Column > 0 && !isUsed[cell.Row, cell.Column - 1] && inputLabirinth[cell.Row, cell.Column - 1] != "X")
                {
                    var newCell = new Cell() { Column = cell.Column - 1, Row = cell.Row, Step = cell.Step + 1 };
                    queue.Enqueue(newCell);
                    isUsed[newCell.Row, newCell.Column] = true;
                    outputLabyrinth[newCell.Row, newCell.Column] = newCell.Step.ToString();
                }

                // Check and enqueue right cell
                if (cell.Column < inputLabirinth.GetLength(1) - 1 && !isUsed[cell.Row, cell.Column + 1] && inputLabirinth[cell.Row, cell.Column + 1] != "X")
                {
                    var newCell = new Cell() { Column = cell.Column + 1, Row = cell.Row, Step = cell.Step + 1 };
                    queue.Enqueue(newCell);
                    isUsed[newCell.Row, newCell.Column] = true;
                    outputLabyrinth[newCell.Row, newCell.Column] = newCell.Step.ToString();
                }

                // Check and enqueue top cell
                if (cell.Row > 0 && !isUsed[cell.Row - 1, cell.Column] && inputLabirinth[cell.Row - 1, cell.Column] != "X")
                {
                    var newCell = new Cell() { Column = cell.Column, Row = cell.Row - 1, Step = cell.Step + 1 };
                    queue.Enqueue(newCell);
                    isUsed[newCell.Row, newCell.Column] = true;
                    outputLabyrinth[newCell.Row, newCell.Column] = newCell.Step.ToString();
                }

                // Check and enqueue bottom cell
                if (cell.Row < inputLabirinth.GetLength(0) - 1 && !isUsed[cell.Row + 1, cell.Column] && inputLabirinth[cell.Row + 1, cell.Column] != "X")
                {
                    var newCell = new Cell() { Column = cell.Column, Row = cell.Row + 1, Step = cell.Step + 1 };
                    queue.Enqueue(newCell);
                    isUsed[newCell.Row, newCell.Column] = true;
                    outputLabyrinth[newCell.Row, newCell.Column] = newCell.Step.ToString();
                }
            }

            // Fill the missing cells
            for (int row = 0; row < outputLabyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < outputLabyrinth.GetLength(1); col++)
                {
                    if (outputLabyrinth[row, col] == null)
                    {
                        outputLabyrinth[row, col] = "U";
                    }

                    if (inputLabirinth[row, col] == "X")
                    {
                        outputLabyrinth[row, col] = "X";
                    }
                }
            }
        }

        public static Cell FindStartingCell()
        {
            var startingCell = new Cell()
            {
                Step = 0
            };
            var haveFoundStartingCell = false;

            for (int row = 0; row < inputLabirinth.GetLength(0); row++)
            {
                for (int col = 0; col < inputLabirinth.GetLength(1); col++)
                {
                    if (inputLabirinth[row, col] == "*")
                    {
                        startingCell.Row = row;
                        startingCell.Column = col;
                        haveFoundStartingCell = true;
                        break;
                    }
                }

                if (haveFoundStartingCell)
                {
                    break;
                }
            }

            return startingCell;
        }

        public static void PrintOutputLabyrinth(string[,] outputLabyrinth)
        {
            for (int row = 0; row < outputLabyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < outputLabyrinth.GetLength(1); col++)
                {
                    Console.Write(outputLabyrinth[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
