using hs_bgs_predictor.core;
using hs_bgs_predictor.entities.models;
using hs_bgs_predictor.helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace hs_bgs_predictor.entities.constants
{
    public class Cards
    {
        public static Card ARGENT_PROTECTOR = new Card("Argent Protector", 1, 1,
            new List<CardProperty>(1) { new CardProperty() {
                Type = enums.CardPropertyType.DIVINE_SHIELD
            }});

        public static Card KABOOM_BOT = new Card("Kaboom Bot", 2, 2,
            new List<CardProperty>(1) { new CardProperty()
            {
                Type = enums.CardPropertyType.DEATHRATTLE,
                Action = () => {
                    Battleground bg = BattlegroundHelper.CurrentBattleground;

                    if (bg.EnemyBoard.Cards.Count > 0)
                    {
                        sbyte index = RandomHelper.PickRandom(bg.EnemyBoard.Cards.Count - 1);
                        bg.EnemyBoard.Cards[index].DecreaseLife(2);
                    }
                }
            }});
    }
}
