namespace ArrowFactories;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Arrow Factories";
        Console.WriteLine("Welcome to Vin Fletcher's! We make the best arrows in the region.");
        Console.ReadKey();

        Arrow arrow = GetArrow();

        Console.WriteLine($"Your arrow costs {arrow.Cost} gold pieces.");

        Console.ReadKey();
    }

    public static Arrow GetArrow()
    {
        Console.WriteLine("Here are the types of arrows I usually make: ");
        Console.WriteLine("1 - Beginner Arrow");
        Console.WriteLine("2 - Marksman Arrow");
        Console.WriteLine("3 - Elite Arrow");
        Console.WriteLine("4 - Custom Arrow");
        Console.Write("Pick your poison: ");
        
        string choice = Console.ReadLine();

        Arrow arrow = choice switch
        {
            "1" => Arrow.CreateBeginnerArrow(),
            "2" => Arrow.CreateMarksmanArrow(),
            "3" => Arrow.CreateEliteArrow(),
            _ => CreateCustomArrow(),
        };

        return arrow;
    }

    public static Arrow CreateCustomArrow()
    {
        Arrowhead arrowhead = GetArrowhead();
        Fletching fletching = GetFletching();
        float length = GetLength();

        return new Arrow(arrowhead, fletching, length);
    }

    public static Arrowhead GetArrowhead()
    {
        Console.WriteLine("Choose an arrowhead: ");
        Console.WriteLine("1 - Wood - 3gp");
        Console.WriteLine("2 - Obsidian - 5gp");
        Console.WriteLine("3 - Steel - 10gp");
        Console.Write("Make your choice: ");
        string choice = Console.ReadLine();
        return choice switch
        {
            "1" => Arrowhead.Wood,
            "2" => Arrowhead.Obsidian,
            "3" => Arrowhead.Steel,
        };
    }

    public static Fletching GetFletching()
    {
        Console.WriteLine("Choose a fletching: ");
        Console.WriteLine("1 - Plastic - 10gp");
        Console.WriteLine("2 - Turkey Feathers - 5gp");
        Console.WriteLine("3 - Goose Feathers - 3gp");
        Console.Write("Make your choice: ");
        string choice = Console.ReadLine();
        return choice switch
        {
            "1" => Fletching.Plastic,
            "2" => Fletching.Turkey,
            "3" => Fletching.Goose,
        };
    }

    public static float GetLength()
    {
        Console.Write("Now, choose a length (between 60 and 100): ");
        float length = 0;
        while (length < 60 || length > 100)
        {
            length = Convert.ToSingle(Console.ReadLine());
        }
        return length;
    }

    public class Arrow
    {
        public Arrowhead Arrowhead { get; }
        public Fletching Fletching { get; }
        public float Length { get; }

        public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
        {
            Arrowhead = arrowhead;
            Fletching = fletching;
            Length = length;
        }

        public float Cost
        {
            get
            {
                float arrowheadCost = Arrowhead switch
                {
                    Arrowhead.Wood => 3,
                    Arrowhead.Obsidian => 5,
                    Arrowhead.Steel => 10,
                };
                float fletchingCost = Fletching switch
                {
                    Fletching.Plastic => 10,
                    Fletching.Turkey => 5,
                    Fletching.Goose => 3,
                };
                float lengthCost = Length * 0.05f;
                return arrowheadCost + fletchingCost + lengthCost;
            }
        }

        public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead.Wood, Fletching.Goose, 75);
        public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead.Steel, Fletching.Goose, 65);
        public static Arrow CreateEliteArrow() => new Arrow(Arrowhead.Steel, Fletching.Plastic, 95);
    }

    public enum Arrowhead { Wood, Obsidian, Steel }
    public enum Fletching { Plastic, Turkey, Goose }
}
