using System.Collections.Generic;

namespace PrisonDilemma
{

	public class Strategy_Tit_For_2Tat : IStrategy
	{
		public override string ToString()
		{
			return "Tit_For_2Tat";

		}

		public bool GetNextMove(List<bool> knownMoves)
		{
			int j = 0;
			for (int i = 0; i < knownMoves.Count; i++) 
			{if (knownMoves[i] == false) { j++; }}



			if (knownMoves.Count == 0) { return true; }
			else if (j < 2) { return true; }
			else 
			{ return knownMoves[knownMoves.Count - 1]; }


		}


	}
}