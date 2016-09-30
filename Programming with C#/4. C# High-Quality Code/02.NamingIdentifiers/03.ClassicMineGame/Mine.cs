//03. Refactor and improve the naming in the C# source project “3. Naming-Identifiers-Homework.zip”. You are allowed to make other 
//improvements in the code as well (not only naming) as well as to fix bugs.

namespace _03.ClassicMineGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mine
    {
        private const int MAX_SCORE = 35;
        private const int NUMBER_OF_PLAYERS = 5;
        private const int ROW_SIZE = 5;
        private const int COLUMN_SIZE = 10;

        public static void Main(string[] args)
        {
            string command = string.Empty;
            int commandLength = 3;

            char[,] boardField = CreateBoardField();
            char[,] bombs = BombsPlacement();

            int currentScore = 0;
            int row = 0;
            int colomn = 0;

            bool newGame = true;
            bool gameOver = false;
            bool gameWon = false;

            List<Player> playersList = new List<Player>(6);

            do
            {
                if (newGame == true)
                {
                    Console.WriteLine("---------- Lets play \"Classic Mine Game\"----------\n");
                    Console.WriteLine("Try your luck and found fields without mines.");
                    Console.WriteLine("Commands: 'top' - shows the ranking, 'restart' - restart the game, 'exit' - exit from the game");

                    PrintBoard(boardField);
                    newGame = false;
                }

                Console.Write("Enrer row and column: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= commandLength)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out colomn) &&
                        row <= boardField.GetLength(0) && colomn <= boardField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintRanking(playersList);
                        break;
                    case "restart":
                        boardField = CreateBoardField();
                        bombs = BombsPlacement();
                        PrintBoard(boardField);
                        gameOver = false;
                        newGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    case "turn":
                        if (bombs[row, colomn] != '*')
                        {
                            if (bombs[row, colomn] == '-')
                            {
                                CreateSurrondingEnvironment(boardField, bombs, row, colomn);
                                currentScore++;
                            }

                            if (MAX_SCORE == currentScore)
                            {
                                gameWon = true;
                            }
                            else
                            {
                                PrintBoard(boardField);
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (gameOver == true)
                {
                    PrintBoard(bombs);
                    Console.Write("\nYou died with {0} points. Enter nickname: ", currentScore);
                    string nickname = Console.ReadLine();
                    
                    Player player = new Player(nickname, currentScore);

                    if (playersList.Count < NUMBER_OF_PLAYERS)
                    {
                        playersList.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < playersList.Count; i++)
                        {
                            if (playersList[i].Points < player.Points)
                            {
                                playersList.Insert(i, player);
                                playersList.RemoveAt(playersList.Count - 1);
                                break;
                            }
                        }
                    }

                    playersList.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    playersList.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    PrintRanking(playersList);

                    boardField = CreateBoardField();
                    bombs = BombsPlacement();
                    currentScore = 0;
                    gameOver = false;
                    newGame = true;
                }

                if (gameWon == true)
                {
                    Console.WriteLine("\nCongratulations! You WON!.");
                    PrintBoard(bombs);

                    Console.WriteLine("Enter nickname: ");
                    string nickname = Console.ReadLine();

                    Player currentPlayer = new Player(nickname, currentScore);
                    playersList.Add(currentPlayer);
                    PrintRanking(playersList);

                    boardField = CreateBoardField();
                    bombs = BombsPlacement();
                    currentScore = 0;
                    gameWon = false;
                    newGame = true;
                }
            }
            while (command != "exit");
            Console.Read();
        }

        private static void PrintRanking(List<Player> points)
        {
            Console.WriteLine("\nPoints: ");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty ranking!\n");
            }
        }

        private static void CreateSurrondingEnvironment(char[,] boardField, char[,] bombs, int row, int column)
        {
            char bombsNumber = CheckForBombsCount(bombs, row, column);
            bombs[row, column] = bombsNumber;
            boardField[row, column] = bombsNumber;
        }

        private static void PrintBoard(char[,] boardField)
        {
            int rowsNumber = boardField.GetLength(0);
            int columnsNumber = boardField.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rowsNumber; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < columnsNumber; j++)
                {
                    Console.Write(string.Format("{0} ", boardField[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateBoardField()
        {
            int rows = ROW_SIZE;
            int columns = COLUMN_SIZE;
            char[,] boardField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    boardField[i, j] = '?';
                }
            }

            return boardField;
        }

        private static char[,] BombsPlacement()
        {
            int rows = ROW_SIZE;
            int columns = COLUMN_SIZE;
            char[,] boardField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    boardField[i, j] = '-';
                }
            }

            List<int> bombMap = new List<int>();

            while (bombMap.Count < 15)
            {
                Random randomGenerator = new Random();

                int location = randomGenerator.Next(50);

                if (!bombMap.Contains(location))
                {
                    bombMap.Add(location);
                }
            }

            foreach (int element in bombMap)
            {
                int column = element / columns;
                int field = element % columns;

                if (field == 0 && element != 0)
                {
                    column--;
                    field = columns;
                }
                else
                {
                    field++;
                }

                boardField[column, field - 1] = '*';
            }

            return boardField;
        }

        private static void CheckForBombs(char[,] boardField)
        {
            int column = boardField.GetLength(0);
            int row = boardField.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (boardField[i, j] != '*')
                    {
                        char neighbourBombsCount = CheckForBombsCount(boardField, i, j);
                        boardField[i, j] = neighbourBombsCount;
                    }
                }
            }
        }

        private static char CheckForBombsCount(char[,] bombs, int row, int column)
        {
            int counter = 0;
            int rowsNumber = bombs.GetLength(0);
            int columnsNumber = bombs.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombs[row - 1, column] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < rowsNumber)
            {
                if (bombs[row + 1, column] == '*')
                {
                    counter++;
                }
            }

            if (column - 1 >= 0)
            {
                if (bombs[row, column - 1] == '*')
                {
                    counter++;
                }
            }

            if (column + 1 < columnsNumber)
            {
                if (bombs[row, column + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (bombs[row - 1, column - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columnsNumber))
            {
                if (bombs[row - 1, column + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rowsNumber) && (column - 1 >= 0))
            {
                if (bombs[row + 1, column - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rowsNumber) && (column + 1 < columnsNumber))
            {
                if (bombs[row + 1, column + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}
