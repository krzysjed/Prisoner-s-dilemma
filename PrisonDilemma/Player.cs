using System.Collections.Generic;

namespace PrisonDilemma
{
    class Player
    {
        private IStrategy currentStrategy; // the algorithm used to make moves
        public List<bool> PartnerMoves { get; set; } // true means cooperation, false means betrayal
        
        public int Score { get; set; } 

        public Player(IStrategy initialStrategy)
        {
            PartnerMoves = new List<bool>();
           
            currentStrategy = initialStrategy;
        }
        public void SetStrategy(IStrategy newStrategy)
        {
            currentStrategy = newStrategy;
        }

        public bool GetNextMove()
        {
            return currentStrategy.GetNextMove(PartnerMoves);
        }


        public IStrategy GetStrategy()
        {
            return currentStrategy;
        }



    }
}
