using hs_bgs_predictor.core;
using hs_bgs_predictor.entities.enums;
using hs_bgs_predictor.helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace hs_bgs_predictor.entities.models
{
    public class Card
    {
        public string Name { get; set; }
        public sbyte Attack { get; set; }
        private sbyte Life { get; set; }

        private Guid UniqueId { get; set; }
        
        public List<CardProperty> CardProperties { get; set; }

        public Card(string name, sbyte attack, sbyte life, List<CardProperty> cardProperties)
        {
            this.Name = name;
            this.Attack = attack;
            this.Life = life;
            this.CardProperties = cardProperties ?? new List<CardProperty>();
            this.UniqueId = new Guid();
        }

        public void executeEffect()
        {
            this.CardProperties.Find(i => i.Type.Equals(CardPropertyType.EFFECT)).Action.Invoke();
        }

        public void executeDeathrattle()
        {
            this.CardProperties.Find(i => i.Type.Equals(CardPropertyType.DEATHRATTLE)).Action.Invoke();
        }

        public bool hasTaunt()
        {
            return this.CardProperties.Exists(i => i.Type.Equals(CardPropertyType.TAUNT));
        }

        public bool hasDivineShield()
        {
            return this.CardProperties.Exists(i => i.Type.Equals(CardPropertyType.DIVINE_SHIELD));
        }

        public bool hasPoisonous()
        {
            return this.CardProperties.Exists(i => i.Type.Equals(CardPropertyType.POISONOUS));
        }

        public CardProperty findEffect()
        {
            return this.CardProperties.Find(i => i.Type.Equals(CardPropertyType.EFFECT));
        }

        public CardProperty findDeathrattle()
        {
            return this.CardProperties.Find(i => i.Type.Equals(CardPropertyType.DEATHRATTLE));
        }

        public void DecreaseLife(sbyte amount)
        {
            this.Life -= amount;

            if (this.Life <= 0)
            {
                findDeathrattle()?.Action.Invoke();

                BattlegroundHelper.CurrentBattleground.MyBoard.Cards.Remove(this);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Card)
            {
                return this.UniqueId.Equals((obj as Card).UniqueId);
            }
            else return false;
        }
    }
}