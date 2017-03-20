namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class StartMinesweeper
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] board = GenerateBoard();
            char[,] mines = GenerateMines();
            int openedFields = 0;
            bool hitMine = false;
            List<Player> players = new List<Player>();
            int row = 0;
            int column = 0;
            bool startGame = true;
            bool playerWins = false;

            do
            {
                if (startGame)
                {
                    Console.WriteLine(Constants.WelcomeMessage);
                    GenerateBoard(board);
                    startGame = false;
                }

                Console.Write(Constants.RequestCoordinates);
                command = Console.ReadLine().Trim();
                if (command.Length >= Constants.CommandLength)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= board.GetLength(0) && column <= board.GetLength(1))
                    {
                        command = Constants.NewTurn;
                    }
                }

                switch (command)
                {
                    case Constants.DisplayRanking:
                        Ranking(players);
                        break;
                    case Constants.RestartGame:
                        board = GenerateBoard();
                        mines = GenerateMines();
                        GenerateBoard(board);
                        hitMine = false;
                        startGame = false;
                        break;
                    case Constants.ExitGame:
                        Console.WriteLine(Constants.GoodbyeMessage);
                        break;
                    case Constants.NewTurn:
                        if (mines[row, column] != Constants.FieldWithMine)
                        {
                            if (mines[row, column] == '-')
                            {
                                PlayerTurn(board, mines, row, column);
                                openedFields++;
                            }

                            if (Constants.MaxOpenedFields == openedFields)
                            {
                                playerWins = true;
                            }
                            else
                            {
                                GenerateBoard(board);
                            }
                        }
                        else
                        {
                            hitMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine(Constants.InvalidCommandMessage);
                        break;
                }

                if (hitMine)
                {
                    GenerateBoard(mines);
                    Console.Write(Constants.GameOverMessage, openedFields);
                    string name = Console.ReadLine();
                    Player currentPlayer = new Player(name, openedFields);
                    if (players.Count < Constants.BoardRows)
                    {
                        players.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].Points < currentPlayer.Points)
                            {
                                players.Insert(i, currentPlayer);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }

                    players.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    players.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    Ranking(players);

                    board = GenerateBoard();
                    mines = GenerateMines();
                    openedFields = 0;
                    hitMine = false;
                    startGame = true;
                }

                if (playerWins)
                {
                    Console.WriteLine(Constants.YouWinMessage);
                    GenerateBoard(mines);
                    Console.WriteLine(Constants.RequestPlayerNameForRanking);
                    string playerName = Console.ReadLine();
                    Player player = new Player(playerName, openedFields);
                    players.Add(player);
                    Ranking(players);
                    board = GenerateBoard();
                    mines = GenerateMines();
                    openedFields = 0;
                    playerWins = false;
                    startGame = true;
                }
            }
            while (command != Constants.ExitGame);
            Console.Read();
        }

        private static void Ranking(List<Player> players)
        {
            Console.WriteLine(Constants.RankingHeader);
            if (players.Count > 0)
            {
                for (int index = 0; index < players.Count; index++)
                {
                    Console.WriteLine(Constants.RankingPointsString, index + 1, players[index].Name, players[index].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(Constants.NoCurrentlyRankedPlayers);
            }
        }

        private static void PlayerTurn(char[,] board, char[,] mines, int row, int column)
        {
            char minesCount = CalculateMinesCount(mines, row, column);
            mines[row, column] = minesCount;
            board[row, column] = minesCount;
        }

        private static void GenerateBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine(Constants.RowsNumbers);
            Console.WriteLine(Constants.BoardHorizontalBorder);
            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} {1} ", row, Constants.BoardVerticalalBorder);
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }

                Console.Write(Constants.BoardVerticalalBorder);
                Console.WriteLine();
            }

            Console.WriteLine(Constants.BoardHorizontalBorder);
        }

        private static char[,] GenerateBoard()
        {
            int boardRows = Constants.BoardRows;
            int boardColumns = Constants.BoardColumns;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = Constants.UnopenedField;
                }
            }

            return board;
        }

        private static char[,] GenerateMines()
        {
            int rows = Constants.BoardRows;
            int columns = Constants.BoardColumns;
            char[,] field = new char[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    field[row, col] = Constants.GameOverEmptyField;
                }
            }

            List<int> adjasentMinesCount = new List<int>();
            while (adjasentMinesCount.Count < Constants.MaxNumberOfMines)
            {
                Random random = new Random();
                int cellNumber = random.Next(Constants.RandomNumberGenerator);
                if (!adjasentMinesCount.Contains(cellNumber))
                {
                    adjasentMinesCount.Add(cellNumber);
                }
            }

            foreach (int minesNumber in adjasentMinesCount)
            {
                int column = (minesNumber / columns);
                int row = (minesNumber % columns);
                if (row == 0 && minesNumber != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                field[column, row - 1] = Constants.FieldWithMine;
            }

            return field;
        }

        private static void CalculateAdjasentMines(char[,] board)
        {
            int columns = board.GetLength(0);
            int rows = board.GetLength(1);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] != Constants.FieldWithMine)
                    {
                        char minesNumber = CalculateMinesCount(board, i, j);
                        board[i, j] = minesNumber;
                    }
                }
            }
        }

        private static char CalculateMinesCount(char[,] mine, int rows, int cols)
        {
            int minesCount = 0;
            int rowx = mine.GetLength(0);
            int columns = mine.GetLength(1);

            if (rows - 1 >= 0)
            {
                if (mine[rows - 1, cols] == Constants.FieldWithMine)
                {
                    minesCount++;
                }
            }

            if (rows + 1 < rowx)
            {
                if (mine[rows + 1, cols] == Constants.FieldWithMine)
                {
                    minesCount++;
                }
            }

            if (cols - 1 >= 0)
            {
                if (mine[rows, cols - 1] == Constants.FieldWithMine)
                {
                    minesCount++;
                }
            }

            if (cols + 1 < columns)
            {
                if (mine[rows, cols + 1] == Constants.FieldWithMine)
                {
                    minesCount++;
                }
            }

            if ((rows - 1 >= 0) && (cols - 1 >= 0))
            {
                if (mine[rows - 1, cols - 1] == Constants.FieldWithMine)
                {
                    minesCount++;
                }
            }

            if ((rows - 1 >= 0) && (cols + 1 < columns))
            {
                if (mine[rows - 1, cols + 1] == Constants.FieldWithMine)
                {
                    minesCount++;
                }
            }

            if ((rows + 1 < rowx) && (cols - 1 >= 0))
            {
                if (mine[rows + 1, cols - 1] == Constants.FieldWithMine)
                {
                    minesCount++;
                }
            }

            if ((rows + 1 < rowx) && (cols + 1 < columns))
            {
                if (mine[rows + 1, cols + 1] == Constants.FieldWithMine)
                {
                    minesCount++; 
                }
            }

            return char.Parse(minesCount.ToString());
        }
    }
}
