namespace MinesweeperGame
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {
        public static void Main()
        {
            const int FieldsWithoutMines = 35;
            string command = string.Empty;
            char[,] playingBoard = CreateBoard();
            char[,] minesBoard = DeployMines();
            int playerPoints = 0;
            int row = 0;
            int col = 0;
            bool hasSteppedOnMine = false;
            bool isAtStartOfTheGame = true;
            bool hasWonTheGame = false;
            List<Score> highscores = new List<Score>(6);

            do
            {
                if (isAtStartOfTheGame)
                {
                    Console.WriteLine("Let's play 'Minesweeper'! Try stepping only on spots without mines." +
                    " The 'top' command shows the leaderboard, use 'restart' to reset the game, use 'exit' to stop the game!");
                    DrawBoard(playingBoard);
                    isAtStartOfTheGame = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row < playingBoard.GetLength(0) && col < playingBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        DisplayLeaderBoard(highscores);
                        break;
                    case "restart":
                        playingBoard = CreateBoard();
                        minesBoard = DeployMines();
                        DrawBoard(playingBoard);
                        hasSteppedOnMine = false;
                        isAtStartOfTheGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye bye!");
                        break;
                    case "turn":
                        if (minesBoard[row, col] != '*')
                        {
                            if (minesBoard[row, col] == '-')
                            {
                                ShowSpotValue(playingBoard, minesBoard, row, col);
                                playerPoints++;
                            }

                            if (FieldsWithoutMines == playerPoints)
                            {
                                hasWonTheGame = true;
                            }
                            else
                            {
                                DrawBoard(playingBoard);
                            }
                        }
                        else
                        {
                            hasSteppedOnMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (hasSteppedOnMine)
                {
                    DrawBoard(minesBoard);
                    Console.Write("\nGame over! You died with {0} points. " + "Enter nickname: ", playerPoints);
                    string nickname = Console.ReadLine();
                    Score playerScore = new Score(nickname, playerPoints);
                    if (highscores.Count < 5)
                    {
                        highscores.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < highscores.Count; i++)
                        {
                            if (highscores[i].PlayerPoints < playerScore.PlayerPoints)
                            {
                                highscores.Insert(i, playerScore);
                                highscores.RemoveAt(highscores.Count - 1);
                                break;
                            }
                        }
                    }

                    highscores.Sort((Score playerOne, Score playerTwo) => playerTwo.PlayerName.CompareTo(playerOne.PlayerName));
                    highscores.Sort((Score playerOne, Score playerTwo) => playerTwo.PlayerPoints.CompareTo(playerOne.PlayerPoints));
                    DisplayLeaderBoard(highscores);

                    playingBoard = CreateBoard();
                    minesBoard = DeployMines();
                    playerPoints = 0;
                    hasSteppedOnMine = false;
                    isAtStartOfTheGame = true;
                }

                if (hasWonTheGame)
                {
                    Console.WriteLine("\nCongratulations! You won the game!");
                    DrawBoard(minesBoard);
                    Console.WriteLine("Enter nickname: ");
                    string playerName = Console.ReadLine();
                    Score playerScore = new Score(playerName, playerPoints);
                    highscores.Add(playerScore);
                    DisplayLeaderBoard(highscores);
                    playingBoard = CreateBoard();
                    minesBoard = DeployMines();
                    playerPoints = 0;
                    hasWonTheGame = false;
                    isAtStartOfTheGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Press any key to continue.");
            Console.Read();
        }

        private static void DisplayLeaderBoard(List<Score> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} spots checked.", i + 1, points[i].PlayerName, points[i].PlayerPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The leaderboard is empty!\n");
            }
        }

        private static void ShowSpotValue(char[,] playingBoard, char[,] minesBoard, int row, int col)
        {
            char numberOfMines = CountMines(minesBoard, row, col);
            minesBoard[row, col] = numberOfMines;
            playingBoard[row, col] = numberOfMines;
        }

        private static void DrawBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateBoard()
        {
            int numberOfRows = 5;
            int numberOfCols = 10;
            char[,] playingBoard = new char[numberOfRows, numberOfCols];

            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfCols; col++)
                {
                    playingBoard[row, col] = '?';
                }
            }

            return playingBoard;
        }

        private static char[,] DeployMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] minesBoard = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    minesBoard[row, col] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int newMine = random.Next(50);
                if (!mines.Contains(newMine))
                {
                    mines.Add(newMine);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / cols;
                int row = mine % cols;

                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                minesBoard[col, row - 1] = '*';
            }

            return minesBoard;
        }

        private static char CountMines(char[,] minesBoard, int row, int col)
        {
            int numberOfMines = 0;
            int rows = minesBoard.GetLength(0);
            int cols = minesBoard.GetLength(1);

            if (row - 1 >= 0)
            {
                if (minesBoard[row - 1, col] == '*')
                {
                    numberOfMines++;
                }
            }

            if (row + 1 < rows)
            {
                if (minesBoard[row + 1, col] == '*')
                {
                    numberOfMines++;
                }
            }

            if (col - 1 >= 0)
            {
                if (minesBoard[row, col - 1] == '*')
                {
                    numberOfMines++;
                }
            }

            if (col + 1 < cols)
            {
                if (minesBoard[row, col + 1] == '*')
                {
                    numberOfMines++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (minesBoard[row - 1, col - 1] == '*')
                {
                    numberOfMines++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (minesBoard[row - 1, col + 1] == '*')
                {
                    numberOfMines++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (minesBoard[row + 1, col - 1] == '*')
                {
                    numberOfMines++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (minesBoard[row + 1, col + 1] == '*')
                {
                    numberOfMines++;
                }
            }

            return char.Parse(numberOfMines.ToString());
        }
    }
}
