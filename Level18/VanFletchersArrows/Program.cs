namespace VanFletchersArrows;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Van Fletcher's Arrows";
        Console.WriteLine("Welcome to Vin Fletcher's! Here you have the best selection of arrows in town.");
        Console.WriteLine("Take a look, and make your choices when you've decided!");

        Arrow arrow = GetArrow();

        Console.WriteLine($"Your {arrow._length}cm {arrow._fletching} fletching {arrow._arrowhead} arrow will cost {arrow.GetCost()} gp.");

        Console.ReadKey();
    }

    public static Arrow GetArrow()
    {
        ArrowHead arrowhead = GetArrowHead();
        Fletching fletching = GetFletching();
        double length = GetLength();
        return new Arrow(arrowhead, fletching, length);
    }

    public static ArrowHead GetArrowHead()
    {
        Console.WriteLine("Let's start with the arrowheads:");
        Console.WriteLine("1 - Steel - 10gp");
        Console.WriteLine("2 - Obsidian - 5gp");
        Console.WriteLine("3 - Wood - 3gp");
        Console.Write("Take your pick: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        return (ArrowHead)choice;
    }

    public static Fletching GetFletching()
    {
        Console.WriteLine("Let's move to the fletching:");
        Console.WriteLine("1 - Plastic - 10gp");
        Console.WriteLine("2 - Turkey Feathers - 5gp");
        Console.WriteLine("3 - Goose Feathers - 3gp");
        Console.Write("Take your pick: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        return (Fletching)choice;
    }

    public static double GetLength()
    {
        Console.WriteLine("Finally, the length. I can make you an arrow between 60 and 100cm long.");
        while (true)
        {
            Console.Write("What is your desired length: ");
            double choice = Convert.ToDouble(Console.ReadLine());

            if (choice >= 60 && choice <= 100)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Sorry, I can only make arrows between 60 and 100cm long.");
            }
        }
    }

    public class Arrow
    {
        public ArrowHead _arrowhead;
        public Fletching _fletching;
        public double _length;

        public Arrow(ArrowHead arrowhead, Fletching fletching, double length)
        {
            _arrowhead = arrowhead;
            _fletching = fletching;
            _length = length;
        }

        public double GetCost()
        {
            double arrowheadCost = _arrowhead switch
            {
                ArrowHead.Steel => 10,
                ArrowHead.Obsidian => 5,
                ArrowHead.Wood => 3
            };

            double fletchingCost = _fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.Turkey => 5,
                Fletching.Goose => 3
            };

            double shaftCost = _length * 0.05;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }

    public enum ArrowHead { Steel = 1, Obsidian = 2, Wood = 3 };
    public enum Fletching { Plastic = 1, Turkey = 2, Goose = 3 };
}
