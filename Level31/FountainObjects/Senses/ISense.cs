using System;
using System.Collections.Generic;
using System.Text;

namespace FountainObjects
{
    public interface ISense
    {
        bool CanSense(GameLogic game);

        void DisplaySense(GameLogic game);
    }
}
