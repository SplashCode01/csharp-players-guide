using System;
using System.Collections.Generic;
using System.Text;

namespace FountainObjects
{
    public class FountainSense : ISense
    {
        public bool CanSense(GameLogic game) => game.CurrentRoom == RoomType.Fountain;

        public void DisplaySense(GameLogic game)
        {
            if (game.FountainState) ConsoleHelper.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!", ConsoleColor.DarkCyan);
            else ConsoleHelper.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!", ConsoleColor.DarkCyan);
        }
    }
}
