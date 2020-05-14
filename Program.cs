using hs_bgs_predictor.core;
using hs_bgs_predictor.entities.constants;
using hs_bgs_predictor.entities.models;
using System;


namespace hs_bgs_predictor
{
    class Program
    {
        static void Main(string[] args)
        {
            BattlegroundBoard myBoard = new BattlegroundBoard();
            myBoard.Cards.Add(Cards.ARGENT_PROTECTOR);
            myBoard.Cards.Add(Cards.ARGENT_PROTECTOR);

            BattlegroundBoard enemyBoard = new BattlegroundBoard();
            enemyBoard.Cards.Add(Cards.KABOOM_BOT);

            Battleground bg = new Battleground(myBoard, enemyBoard);

            bg.run();
            Console.WriteLine("Hello World!");
        }
    }
}
