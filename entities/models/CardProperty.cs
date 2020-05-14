using hs_bgs_predictor.core;
using hs_bgs_predictor.entities.enums;
using System;

namespace hs_bgs_predictor.entities.models
{
    public class CardProperty
    {
        public CardPropertyType Type { get; set; }

        public Action Action { get; set; }
    }
}