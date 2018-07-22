using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CommonList
{
    public static class CommonListExtensions
    {
        //// GENERIC INPUTS

        /// <summary>
        /// Removes a random item from a list and returns it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T RemoveRandom<T>(this IList<T> list)
        {
            if (list.Count == 0) throw new System.IndexOutOfRangeException("Cannot remove a random item from an empty list");
            int randomIndex = UnityEngine.Random.Range(0, list.Count);
            T item = list[randomIndex];
            list.RemoveAt(randomIndex);
            return item;
        }





    }
}
