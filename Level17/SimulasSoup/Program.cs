namespace SimulasSoup;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Simula's Soup";
        Console.WriteLine("Welcome, weary traveller! I'm sure you've had a long and exhausting day.");
        Console.WriteLine("Why don't I make you some soup while you regale me with some stories?");

        (SoupType type, MainIngredient ingredient, Seasoning seasoning) soup = GetSoup();
        Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.type}");

        Console.ReadKey();
    }

    static (SoupType, MainIngredient, Seasoning) GetSoup()
    {
        Seasoning seasoning = GetSeasoning();
        MainIngredient mainIngredient = GetIngredient();
        SoupType soupType = GetSoupType();

        return (soupType, mainIngredient, seasoning);
    }

    static Seasoning GetSeasoning()
    {
        Console.WriteLine("Why don't you tell me where you're from? Oh, here is a menu to get you started:");
        Console.WriteLine("\nFlavors (the most important part!): ");
        Console.WriteLine("0 - Spicy");
        Console.WriteLine("1 - Salty");
        Console.WriteLine("2 - Sweet");
        Console.Write("Pick your poison: ");
        string input = Console.ReadLine();
        return input switch
        {
            "spicy" => Seasoning.spicy,
            "salty" => Seasoning.salty,
            "sweet" => Seasoning.sweet,
        };
    }

    static MainIngredient GetIngredient()
    {
        Console.WriteLine("Ahh, I spent some of my young years in Windows Formia! Oh, pick an ingredient: ");
        Console.WriteLine("0 - Mushrooms");
        Console.WriteLine("1 - Chicken");
        Console.WriteLine("2 - Carrots");
        Console.WriteLine("3 - Potatoes");
        Console.Write("Pick what to munch on : ");
        
        string input = Console.ReadLine();
        return input switch
        {
            "mushrooms" => MainIngredient.mushrooms,
            "chicken" => MainIngredient.chicken,
            "carrots" => MainIngredient.carrots,
            "potatoes" => MainIngredient.potatoes,
        };
    }

    static SoupType GetSoupType()
    {
        Console.WriteLine("Where you headed to now?");
        Console.WriteLine("Ehh, what type of soup you feeling like?");
        Console.WriteLine("0 - Soup");
        Console.WriteLine("1 - Stew");
        Console.WriteLine("2 - Gumbo");
        Console.Write("Thick or thin? ");
        string input = Console.ReadLine();
        return input switch
        {
            "soup" => SoupType.soup,
            "stew" => SoupType.stew,
            "gumbo" => SoupType.gumbo,
        };
    }

    enum SoupType { soup, stew, gumbo };
    enum MainIngredient { mushrooms, chicken, carrots, potatoes };
    enum Seasoning { spicy, salty, sweet };
}
