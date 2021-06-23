using System.Collections.Generic;

namespace PrisonDilemma
{
	public class Strategy_Tit_For_Tat : IStrategy
	{
		public override string ToString()
		{
			return "Tit_For_Tat";
		}

		public bool GetNextMove(List<bool> knownMoves)
		{

			if (knownMoves.Count == 0) {return true; } 
			else { return knownMoves[knownMoves.Count - 1]; }

			
		}
	}
}