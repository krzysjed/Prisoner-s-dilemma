using System;
using System.Collections.Generic;

namespace PrisonDilemma
{
	public class Strategy_Repented : IStrategy
	{

		int memory = 0;


		public override string ToString()
		{
			return "Repented";
		}

		public bool GetNextMove(List<bool> knownMoves)
		{


			if (knownMoves.Count == 0) { return true; }

			else
			{
				if (!(knownMoves[knownMoves.Count - 1]) && memory > 0) // Take that izi
				{
					memory--;
					return true;
				}

				else if (!knownMoves[knownMoves.Count - 1]) { return false; }

				else
				{
					Random rnd = new Random();
					if (rnd.NextDouble() >= 0.3) { return true; }
					else
					{
						memory++;
						return false;
					}
				}
			}
		}
	}
}