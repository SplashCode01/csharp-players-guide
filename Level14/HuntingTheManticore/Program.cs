namespace HuntingTheManticore;

class Program
{
    static void Main(string[] args)
    {
        int manticoreHealth = 10;
        int cityHealth = 15;
        int round = 1;

        Console.Title = "Hunting the Manticore";

        Console.WriteLine("Welcome to Hunting the Manticore!");
        Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
        int manticorePosition = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Player 2, it is your turn.");

        while (manticoreHealth > 0 && cityHealth > 0)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
            Console.WriteLine("The cannon is expected to deal 1 damage this round.");
            Console.Write("Enter desired cannon range: ");
            int range = Convert.ToInt32(Console.ReadLine());

            if (range > manticorePosition) Console.WriteLine("That round OVERSHOT the target.");
            else if (range < manticorePosition) Console.WriteLine("That round FELL SHORT of the target.");
            else
            {
                manticoreHealth -= CalculateDamage(round);
                Console.WriteLine("That round was a DIRECT HIT!");
            }

            cityHealth--;
            round++;
        }

        if(manticoreHealth <= 0) Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        else Console.WriteLine("The Manticore has destroyed the city! Flee!");

        Console.ReadKey();
    }

    static int CalculateDamage(int round)
    {
        if (round % 3 == 0 && round % 5 == 0) return 10;
        else if (round % 3 == 0 || round % 5 == 0) return 3;
        else return 1;
    }
}
