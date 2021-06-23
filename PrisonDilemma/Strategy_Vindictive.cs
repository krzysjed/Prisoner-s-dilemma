using System.Collections.Generic;

namespace PrisonDilemma
{
	public class Strategy_Vindictive : IStrategy
	{
		public override string ToString()
		{
			return "Vindictive";
		}

		public bool GetNextMove(List<bool> knownMoves)
		{
			if (knownMoves.Contains(false)) { return false; }
            else { return true; }
		}
	}
}