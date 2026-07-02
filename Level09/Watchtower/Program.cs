namespace Watchtower;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Watchtower";

        Console.WriteLine("Soldier! Grab your spyglass and map and tell me where the enemies are!");
        Console.Write("\nWhat is their horizontal position? ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is their vertical position? ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == 0 & y == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The enemies are at our doorstep!");
        }
        else if (x == 0)
        {
            if (y > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The enemies are to the North!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The enemies are to the South!");
            }
        }
        else if (y == 0)
        {
            if (x > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The enemies are to the East!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The enemies are to the West!");
            }
        }
        else if (x > 0 & y > 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The enemies are to the North-East!");
        }
        else if (x < 0 & y > 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The enemies are to the North-West!");
        }
        else if (x < 0 & y < 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The enemies are to the South-West!");
        }
        else if (x > 0 & y < 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The enemies are to the South-East!");
        }

        Console.ReadKey();
    }
}
