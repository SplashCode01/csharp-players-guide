namespace ConsolasDefense;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Commander! Our city is under attack. The defense squad is ready for orders!");
        Console.Write("What is the target row? ");
        int targetRow = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the target column? ");
        int targetColumn = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "Consolas Defense";

        Console.WriteLine("\nDeploy to these coordinates now!");
        Console.WriteLine($"({targetRow}, {targetColumn - 1})");
        Console.WriteLine($"({targetRow + 1}, {targetColumn})");
        Console.WriteLine($"({targetRow}, {targetColumn + 1})");
        Console.WriteLine($"({targetRow - 1}, {targetColumn})");
        Console.Beep();

        Console.ReadKey();
    }
}
