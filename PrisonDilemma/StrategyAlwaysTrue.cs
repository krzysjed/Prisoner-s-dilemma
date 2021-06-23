using System.Collections.Generic;

namespace PrisonDilemma
{
    class StrategyAlwaysTrue : IStrategy
    {
        public override string ToString()
        {
            return "AlwaysTrue";
        }

        public bool GetNextMove(List<bool> knownMoves)
        {
            return true;
        }
    }
}
