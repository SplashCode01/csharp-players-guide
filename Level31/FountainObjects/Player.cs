using System;
using System.Collections.Generic;
using System.Text;

namespace FountainObjects
{
    public class Player
    {
        public Location CurrentPosition { get; set; }

        public Player(Location start) => CurrentPosition = start;
    }
}
