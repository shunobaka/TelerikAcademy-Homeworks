using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinesweeperGame
{
    public class Mines
    {
        public class Points
        {
            private string name;
            private int currentPoints;

            public Points() { }

            public Points(string name, int points)
            {
                this.name = name;
                this.currentPoints = points;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int CurrentPoints
            {
                get { return currentPoints; }
                set { currentPoints = value; }
            }
        }

        public static void Main(string[] arguments)
        {
            string command = string.Empty;
            char[,] playingBoard = CreateBoard();
            char[,] bombs = DeployBombs();
            int counter = 0;
            bool exploded = false;
            List<Points> topPlayers = new List<Points>(6);
            int row = 0;
            int col = 0;
            bool flag = true;
            const int MAX_FLAGS = 35;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    dumpp(playingBoard);
                    flag = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= playingBoard.GetLength(0) && col <= playingBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        LeaderBoard(topPlayers);
                        break;
                    case "restart":
                        playingBoard = CreateBoard();
                        bombs = DeployBombs();
                        dumpp(playingBoard);
                        exploded = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                tisinahod(playingBoard, bombs, row, col);
                                counter++;
                            }
                            if (MAX_FLAGS == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                dumpp(playingBoard);
                            }
                        }
                        else
                        {
                            exploded = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (exploded)
                {
                    dumpp(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", counter);
                    string niknejm = Console.ReadLine();
                    Points t = new Points(niknejm, counter);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].CurrentPoints < t.CurrentPoints)
                            {
                                topPlayers.Insert(i, t);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }
                    topPlayers.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    topPlayers.Sort((Points r1, Points r2) => r2.CurrentPoints.CompareTo(r1.CurrentPoints));
                    LeaderBoard(topPlayers);

                    playingBoard = CreateBoard();
                    bombs = DeployBombs();
                    counter = 0;
                    exploded = false;
                    flag = true;
                }

                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    dumpp(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Points to4kii = new Points(imeee, counter);
                    topPlayers.Add(to4kii);
                    LeaderBoard(topPlayers);
                    playingBoard = CreateBoard();
                    bombs = DeployBombs();
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void LeaderBoard(List<Points> to4kii)
        {
            Console.WriteLine("\nTo4KI:");
            if (to4kii.Count > 0)
            {
                for (int i = 0; i < to4kii.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, to4kii[i].Name, to4kii[i].CurrentPoints);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void tisinahod(char[,] board,
            char[,] bombs, int row, int col)
        {
            char kolkoBombi = kolko(bombs, row, col);
            bombs[row, col] = kolkoBombi;
            board[row, col] = kolkoBombi;
        }

        private static void dumpp(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] DeployBombs()
        {
            int Редове = 5;
            int Колони = 10;
            char[,] игрално_поле = new char[Редове, Колони];

            for (int i = 0; i < Редове; i++)
            {
                for (int j = 0; j < Колони; j++)
                {
                    игрално_поле[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int kol = i2 / Колони;
                int red = i2 % Колони;

                if (red == 0 && i2 != 0)
                {
                    kol--;
                    red = Колони;
                }
                else
                {
                    red++;
                }

                игрално_поле[kol, red - 1] = '*';
            }

            return игрално_поле;
        }

        private static void smetki(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int red = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char kolkoo = kolko(pole, i, j);
                        pole[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char kolko(char[,] board, int rr, int rrr)
        {
            int brojkata = 0;
            int reds = board.GetLength(0);
            int kols = board.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (board[rr - 1, rrr] == '*')
                {
                    brojkata++;
                }
            }

            if (rr + 1 < reds)
            {
                if (board[rr + 1, rrr] == '*')
                {
                    brojkata++;
                }
            }

            if (rrr - 1 >= 0)
            {
                if (board[rr, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if (rrr + 1 < kols)
            {
                if (board[rr, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (board[rr - 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr - 1 >= 0) && (rrr + 1 < kols))
            {
                if (board[rr - 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr + 1 < reds) && (rrr - 1 >= 0))
            {
                if (board[rr + 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr + 1 < reds) && (rrr + 1 < kols))
            {
                if (board[rr + 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            return char.Parse(brojkata.ToString());
        }
    }
}
