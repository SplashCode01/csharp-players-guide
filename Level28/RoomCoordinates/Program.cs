namespace RoomCoordinates;

class Program
{
    static void Main(string[] args)
    {
        Coordinate a = new Coordinate(3, 3);
        Coordinate b = new Coordinate(2, 3);
        Coordinate c = new Coordinate(2, 2);

        Console.WriteLine(Coordinate.IsAdjacent(a, b));
        Console.WriteLine(Coordinate.IsAdjacent(b, c));
        Console.WriteLine(Coordinate.IsAdjacent(a, c));

        Console.ReadKey();
    }

    public struct Coordinate
    {
        public readonly int Row { get; }
        public readonly int Column { get; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public static bool IsAdjacent(Coordinate a, Coordinate b)
        {
            int rowChange = a.Row - b.Row;
            int columnChange = a.Column - b.Column;

            if (Math.Abs(rowChange) <= 1 && columnChange == 0) return true;
            else if (Math.Abs(columnChange) <= 1 && rowChange == 0) return true;

            return false;
        }
    }
}
