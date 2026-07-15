namespace WarPreparations;

class Program
{
    static void Main(string[] args)
    {
        Sword basicSword = new Sword(Material.Wood, Gemstone.None, 1);
        Sword steelSword = basicSword with { Material = Material.Steel };
        Sword broadSword = steelSword with { Width = 3 };

        Console.WriteLine(basicSword);
        Console.WriteLine(steelSword);
        Console.WriteLine(broadSword);

        Console.ReadKey();
    }
}

public record Sword(Material Material, Gemstone Gemstone, int Width);

public enum Material { Wood, Bronze, Iron, Steel, Binarium }
public enum Gemstone { Emerald, Amber, Sapphire, Diamond, Bitstone, None }