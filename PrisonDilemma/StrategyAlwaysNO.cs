using System.Collections.Generic;

namespace PrisonDilemma
{
    class StrategyAlwaysNO : IStrategy
    {

        public override string ToString()
        {
            return "AlwaysNO";
        }

        public bool GetNextMove(List<bool> knownMoves)
        {
            return false;
        }
    }
}
