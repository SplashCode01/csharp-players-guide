using System;
using System.Collections.Generic;
using System.Text;

namespace FountainObjects
{
    public static class ConsoleHelper
    {
        // Changes to the specified color and then displays the text on its own line.
        public static void WriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }

        // Changes to the specified color and then displays the text without moving to the next line.
        public static void Write(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
        }
    }
}
