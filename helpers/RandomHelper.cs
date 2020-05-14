using System;
using System.Collections.Generic;
using System.Text;

namespace hs_bgs_predictor.helpers
{
    public static class RandomHelper
    {
        public static sbyte PickRandom(int limit)
        {
            return (sbyte) new Random().Next(0, limit);
        }
    }
}
