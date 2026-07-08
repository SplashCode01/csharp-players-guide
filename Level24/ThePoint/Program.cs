namespace ThePoint;

class Program
{
    static void Main(string[] args)
    {
        Point a = new Point(2, 3);
        Point b = new Point(-4, 0);

        Console.WriteLine($"({a.X}, {a.Y})");
        Console.WriteLine($"({b.X}, {b.Y})");

        Console.ReadKey();
    }

    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point()
        {
            X = 0;
            Y = 0;
        }
        
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
