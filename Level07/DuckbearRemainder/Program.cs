namespace DuckbearRemainder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Sisters! Do you need some arbitering?");
        Console.WriteLine("Enter the number of chocolate eggs below, and I will divide everything!");
        int chocoEggs = Convert.ToInt32(Console.ReadLine());
        int remainder = chocoEggs % 4;
        chocoEggs -= remainder;
        chocoEggs /= 4;
        Console.WriteLine($"Sisters! You will each receive {chocoEggs} eggs!");
        Console.WriteLine($"Your bear shall receive {remainder}");
        Console.ReadKey();
    }
}
