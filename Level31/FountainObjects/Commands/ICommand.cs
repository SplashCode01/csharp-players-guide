using System;
using System.Collections.Generic;
using System.Text;

namespace FountainObjects
{
    public interface ICommand
    {
        void Execute(GameLogic game);
    }
}
