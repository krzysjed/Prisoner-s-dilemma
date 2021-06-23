using System;
using System.Collections.Generic;

namespace PrisonDilemma
{

	public class Strategy_Innocent : IStrategy
	{
	
		public override string ToString()
        {
			return "Innocent";
		}

		public bool GetNextMove(List<bool> knownMoves)
		{
			if (knownMoves.Count == 0) { return true; }
			
			else {
				if (!knownMoves[knownMoves.Count - 1]) { return false; }

                else
                {
					Random rnd = new Random();
					return rnd.NextDouble() >= 0.3;
				}
			}
		}
	}
}