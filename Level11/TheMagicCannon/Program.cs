namespace TheMagicCannon;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "The Magic Cannon";

        Console.WriteLine("Hello, Artillerymen! Let me calculate you the gem combinations.");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{i}: Greek Fire");
            }
            else if (i % 3 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{i}: Fire");
            }
            else if (i % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{i}: Electric");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{i}: Normal");
            }
        }

        Console.ReadKey();
    }
}
