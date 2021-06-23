using System;
using System.Collections.Generic;

namespace PrisonDilemma
{
    class Game
    {
        public static void Run()
        {

            List<Player> AllPlayers = new List<Player>();

            AllPlayers.Add(new Player(new Strategy_Tit_For_Tat()));
            AllPlayers.Add(new Player(new Strategy_Innocent()));
            AllPlayers.Add(new Player(new Strategy_Repented()));
            AllPlayers.Add(new Player(new Strategy_Tit_For_2Tat()));
            AllPlayers.Add(new Player(new Strategy_Vindictive()));
            AllPlayers.Add(new Player(new StrategyAlwaysTrue()));
            AllPlayers.Add(new Player(new StrategyAlwaysNO()));

            for (int i = 0; i < AllPlayers.Count - 1; i++)
            {
                for (int j = i + 1; j < AllPlayers.Count; j++)
                {
                    Play(AllPlayers[i], AllPlayers[j]);
                    //Console.WriteLine(i+" "+j);
                    AllPlayers[i].PartnerMoves.Clear();// forgot after match
                    AllPlayers[j].PartnerMoves.Clear();

                }
            }
            ShowScore(AllPlayers);
        }

        public static void Play(Player p1, Player p2)
        {

            int rounds = 30;
            int score1 = 10;
            int score2 = 15;
            int score3 = -10;
            int score4 = 0;

            for (int i = 0; i < rounds; i++)
            {
                bool move1 = p1.GetNextMove();
                bool move2 = p2.GetNextMove();

                if (move1 && move2)
                {

                    p1.Score += score1;
                    p2.Score += score1;

                    p1.PartnerMoves.Add(true);
                    p2.PartnerMoves.Add(true);

                }
                else if (move1) // player2 betrayed player1
                {
                    p1.Score += score3;
                    p2.Score += score2;
                    p1.PartnerMoves.Add(false);
                    p2.PartnerMoves.Add(true);

                }
                else if (move2) // player1 betrayed player2
                {
                    p1.Score += score2;
                    p2.Score += score3;
                    p1.PartnerMoves.Add(true);
                    p2.PartnerMoves.Add(false);

                }
                else // both players betrayed
                {
                    p1.Score += score4;
                    p2.Score += score4;
                    p1.PartnerMoves.Add(false);
                    p2.PartnerMoves.Add(false);

                }
            }
        }

        public static void ShowScore(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {

                Console.WriteLine("Player "+(i+1)+" with tactic: "+players[i].GetStrategy() + ".    Get score: " + players[i].Score);
            }
        }
    }
}