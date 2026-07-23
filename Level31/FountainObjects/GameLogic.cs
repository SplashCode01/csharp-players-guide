using System;
using System.Collections.Generic;
using System.Text;

namespace FountainObjects
{
    public class GameLogic
    {
        public Map GameMap { get; }
        public Player Player { get; }
        public bool FountainState { get; set; }

        private readonly ISense[] _senses;

        public GameLogic(Map map, Player player)
        {
            GameMap = map;
            Player = player;

            _senses = new ISense[]
            {
                new EntranceSense(),
                new FountainSense()
            };
        }

        public void Run()
        {
            while (!HasWon)
            {
                DisplayStatus();
                ICommand command = GetCommand();
                command.Execute(this);

                if (HasWon)
                {
                    ConsoleHelper.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!", ConsoleColor.DarkGreen);
                    ConsoleHelper.WriteLine("You win!", ConsoleColor.DarkGreen);
                }
            }
        }

        private void DisplayStatus()
        {
            ConsoleHelper.WriteLine("--------------------------------------------------------------------------------", ConsoleColor.Gray);
            ConsoleHelper.WriteLine($"You are in the room at (Row={Player.CurrentPosition.Row}, Column={Player.CurrentPosition.Column}).", ConsoleColor.Gray);
            foreach (ISense sense in _senses)
                if (sense.CanSense(this))
                    sense.DisplaySense(this);
        }

        private ICommand GetCommand()
        {
            while (true) // Until we get a legitimate command, keep asking.
            {
                ConsoleHelper.Write("What do you want to do? ", ConsoleColor.White);
                Console.ForegroundColor = ConsoleColor.Cyan;
                string? input = Console.ReadLine();

                if (input == "move north") return new MoveCommand(Direction.North);
                if (input == "move south") return new MoveCommand(Direction.South);
                if (input == "move east") return new MoveCommand(Direction.East);
                if (input == "move west") return new MoveCommand(Direction.West);
                if (input == "enable fountain") return new FountainCommand();

                ConsoleHelper.WriteLine($"I did not understand '{input}'.", ConsoleColor.Red);
            }
        }

        public bool HasWon => CurrentRoom == RoomType.Entrance && FountainState;
        public RoomType CurrentRoom => GameMap.GetRoomType(Player.CurrentPosition);
    }

    
}
