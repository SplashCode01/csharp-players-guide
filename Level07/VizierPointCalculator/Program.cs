Console.WriteLine("Welcome, my liege! I am but your humble vizier, here to help.");
Console.WriteLine("Let me help calculate your points.");
Console.WriteLine("How many estates does your eminence hold?");
int estates = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many duchies does your grace hold?");
int duchies = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many provinces does your majesty hold?");
int provinces = Convert.ToInt32(Console.ReadLine());

int score = estates * 1 + duchies * 3 + provinces * 6;
Console.WriteLine($"My liege! You have an unbelievable {score} points!");
Console.WriteLine("You truly possess the greatest realm in the world!");
Console.ReadKey();
