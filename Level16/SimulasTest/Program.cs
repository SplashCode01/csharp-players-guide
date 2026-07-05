namespace SimulasTest;

class Program
{
    static void Main(string[] args)
    {
        ChestState currentState = ChestState.Locked;
        Console.Title = "Simula's Test";

        Console.WriteLine("Welcome Traveller! Here is a chest for you");

        while (true)
        {
            Console.Write($"The chest is {currentState}. What do you want to do? ");
            string newState = Console.ReadLine();

            currentState = newState switch
            {
                "unlock" when currentState == ChestState.Locked => ChestState.Closed,
                "lock" when currentState == ChestState.Closed => ChestState.Locked,
                "open" when currentState == ChestState.Closed => ChestState.Open,
                "close" when currentState == ChestState.Open => ChestState.Closed,
                _ => currentState
            };
        }

        Console.ReadKey();
    }

    enum ChestState
    {
        Locked,
        Open,
        Closed
    }
}
