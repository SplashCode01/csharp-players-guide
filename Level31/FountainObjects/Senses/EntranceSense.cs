using System;
using System.Collections.Generic;
using System.Text;

namespace FountainObjects
{
    public class EntranceSense : ISense
    {
        public bool CanSense(GameLogic game) => game.CurrentRoom == RoomType.Entrance;

        public void DisplaySense(GameLogic game) => ConsoleHelper.WriteLine("You see light in this room coming from outside the cavern. This is the entrance.", ConsoleColor.Yellow);
    }
}
