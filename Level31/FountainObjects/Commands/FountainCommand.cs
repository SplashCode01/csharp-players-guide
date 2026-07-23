using System;
using System.Collections.Generic;
using System.Text;

namespace FountainObjects
{
    public class FountainCommand : ICommand
    {
        public void Execute(GameLogic game)
        {
            if (game.GameMap.GetRoomType(game.Player.CurrentPosition) == RoomType.Fountain) game.FountainState = true;
            else ConsoleHelper.WriteLine("The fountain is not in this room. There was no effect.", ConsoleColor.Red);
        }
    }
}
