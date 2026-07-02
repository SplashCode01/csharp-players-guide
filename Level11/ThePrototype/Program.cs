namespace ThePrototype;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "The Prototype";
        Console.WriteLine("Hello Players! Let's test your guessing.");

        Console.Write("\nPilot! Enter a number between 0 and 100: ");
        int pilotNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nHunter! Try to guess the number.");
        while (true)
        {
            Console.Write("What is your guess? ");
            int hunterGuess = Convert.ToInt32(Console.ReadLine());
            if (hunterGuess > pilotNumber) Console.WriteLine("Too high!");
            else if (hunterGuess < pilotNumber) Console.WriteLine("Too low!");
            else break;
        }

        Console.WriteLine("You guessed the number!");
        Console.ReadKey();
    }
}
