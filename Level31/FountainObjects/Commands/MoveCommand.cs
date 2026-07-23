using System;
using System.Collections.Generic;
using System.Text;

namespace FountainObjects
{
    public class MoveCommand : ICommand
    {
        public Direction Direction { get; }

        public MoveCommand(Direction direction)
        {
            Direction = direction;
        }

        public void Execute(GameLogic game)
        {
            Location currentLocation = game.Player.CurrentPosition;

            Location newLocation = Direction switch
            {
                Direction.North => new Location(currentLocation.Row - 1, currentLocation.Column),
                Direction.South => new Location(currentLocation.Row + 1, currentLocation.Column),
                Direction.West => new Location(currentLocation.Row, currentLocation.Column - 1),
                Direction.East => new Location(currentLocation.Row, currentLocation.Column + 1)
            };

            if (game.GameMap.IsOnMap(newLocation)) game.Player.CurrentPosition = newLocation;
            else ConsoleHelper.WriteLine("There is a wall there.", ConsoleColor.Red);
        }
    }
}
