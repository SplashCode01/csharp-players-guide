namespace TicTacToe;

class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        Printer printer = new Printer();
        Player player1 = new Player(Cell.X);
        Player player2 = new Player(Cell.O);
        int turn = 0;

        Player currentPlayer = player1;

        while (turn < 9)
        {
            printer.PrintBoard(board);
            Console.WriteLine($"It is {currentPlayer.Symbol}'s turn.");
            int index = currentPlayer.Play(board);
            board.SetSymbol(index, currentPlayer.Symbol);

            if (HasWon(board, currentPlayer.Symbol))
            {
                printer.PrintBoard(board);
                Console.WriteLine($"{currentPlayer.Symbol} has won!");
                break;
            }

            currentPlayer = currentPlayer == player1 ? player2 : player1;
            turn++;
        }

        Console.ReadKey();
    }

    public static bool HasWon(Board board, Cell value)
    {
        int[,] winningCombinations = new int[,]
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8},
            {0, 3, 6},
            {1, 4, 7},
            {2, 5, 8},
            {0, 4, 8},
            {2, 4, 6}
        };
        for (int i = 0; i < winningCombinations.GetLength(0); i++)
        {
            if (board.CurrentSymbol(winningCombinations[i, 0]) == (char)value &&
                board.CurrentSymbol(winningCombinations[i, 1]) == (char)value &&
                board.CurrentSymbol(winningCombinations[i, 2]) == (char)value)
            {
                return true;
            }
        }
        return false;
    }

    public class Player
    {
        public Cell Symbol { get; }
        
        public Player(Cell symbol)
        {
            Symbol = symbol;
        }

        public int Play(Board board)
        {
            while (true)
            {
                Console.Write("What cell do you want to play? (0-8): ");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();

                int cellIndex = key switch
                {
                    ConsoleKey.D0 => 0,
                    ConsoleKey.D1 => 1,
                    ConsoleKey.D2 => 2,
                    ConsoleKey.D3 => 3,
                    ConsoleKey.D4 => 4,
                    ConsoleKey.D5 => 5,
                    ConsoleKey.D6 => 6,
                    ConsoleKey.D7 => 7,
                    ConsoleKey.D8 => 8
                };

                if (board.IsEmpty(cellIndex)) return cellIndex;
                else Console.WriteLine("That cell is already taken.");
            }
        }
    }

    public class Printer
    {
        public void PrintBoard(Board board)
        {
            Console.WriteLine($" {board.CurrentSymbol(0)} | {board.CurrentSymbol(1)} | {board.CurrentSymbol(2)}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board.CurrentSymbol(3)} | {board.CurrentSymbol(4)} | {board.CurrentSymbol(5)}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board.CurrentSymbol(6)} | {board.CurrentSymbol(7)} | {board.CurrentSymbol(8)}");
        }
    }

    public class Board
    {
        private Cell[] _board = new Cell[9];

        public Board()
        {
            Array.Fill(_board, Cell.Empty);
        }

        public char CurrentSymbol(int index) => (char)_board[index];
        public void SetSymbol(int index, Cell symbol) => _board[index] = symbol;
        public bool IsEmpty(int index) => _board[index] == Cell.Empty;
    }
}

public enum Cell
{
    Empty = ' ',
    X = 'X',
    O = 'O'
}
