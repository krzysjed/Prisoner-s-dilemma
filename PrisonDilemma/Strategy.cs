using System.Collections.Generic;

namespace PrisonDilemma
{
    interface IStrategy
    {
        bool GetNextMove(List<bool> knownMoves);

        public abstract string ToString();

    }
}
