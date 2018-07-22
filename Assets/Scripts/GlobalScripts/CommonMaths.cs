using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommonMaths
{
    public static class CommonMathExtensions {
        
        public static float Map (this float x, float in_min, float in_max, float out_min, float out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }

        public static int WithRandomSign(this int value, float negativeProbability = 0.5f)
        {
            return Random.value < negativeProbability ? -value : value;
        }





    }

}

