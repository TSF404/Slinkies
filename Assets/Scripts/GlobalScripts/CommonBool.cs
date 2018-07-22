using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CommonBool
{
    public static class CommonBoolExtensions
    {
        //// STRING INPUTS
        public static bool IsIn(this string input, List<string> list)
        {
            return list.Contains(input);
        }

        public static bool IsNotIn(this string input, List<string> list)
        {
            return !input.IsIn(list);
        }



        //// INT INPUTS
        public static bool IsIn(this int input, List<int> list)
        {
            return list.Contains(input);
        }

        public static bool IsNotIn(this int input, List<int> list)
        {
            return !input.IsIn(list);
        }




        //// FLOAT INPUTS
        public static bool IsIn(this float input, List<float> list)
        {
            return list.Contains(input);
        }

        public static bool IsNotIn(this float input, List<float> list)
        {
            return !input.IsIn(list);
        }

    }
}