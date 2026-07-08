using System.Drawing;

namespace TheColor;

class Program
{
    static void Main(string[] args)
    {
        Color random = new Color(55, 150, 200);
        Color fixedColor = Color.Orange;

        Console.WriteLine($"R={random.R} G={random.G} B={random.B}");
        Console.WriteLine($"R={fixedColor.R} G={fixedColor.G} B={fixedColor.B}");

        Console.ReadKey();
    }

    public class Color {
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }

        public static Color White { get; } = new Color(255, 255, 255);
        public static Color Black { get; } = new Color(0, 0, 0);
        public static Color Red { get; } = new Color(255, 0, 0);
        public static Color Orange { get; } = new Color(255, 165, 0);
        public static Color Yellow { get; } = new Color(255, 255, 0);
        public static Color Green { get; } = new Color(0, 128, 0);
        public static Color Blue { get; } = new Color(0, 0, 255);
        public static Color Purple { get; } = new Color(128, 0, 128);

        public Color()
        {
            R = 0;
            G = 0;
            B = 0;
        }
        
        public Color(byte red, byte green, byte blue)
        {
            R = red;
            G = green;
            B = blue;
        }
    }
}
