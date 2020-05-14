using System.Collections.Generic;

namespace hs_bgs_predictor.entities.models
{
    public class BattlegroundBoard
    {
        public List<Card> Cards { get; set; }

        public BattlegroundBoard()
        {
            this.Cards = new List<Card>();
        }

        public bool executeNext()
        {
            if (Cards.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}