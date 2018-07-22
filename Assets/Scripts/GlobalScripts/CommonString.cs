using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CommonString
{
    public static class CommonStringExtensions
    {

        /// <summary>
        /// Returns the first letter of a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string FirstLetter (this string input)
        {
            if (input.Length == 0) throw new System.ArgumentOutOfRangeException("Cannot find the first letter of an empty string");
            return input[0] + "";
        }

        /// <summary>
        /// Returns the last letter of a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string LastLetter(this string input)
        {
            if (input.Length == 0) throw new System.ArgumentOutOfRangeException("Cannot find the last letter of an empty string");
            return input[input.Length - 1] + "";
        }
    }
}

