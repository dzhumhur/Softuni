namespace _01.CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public static class Extension
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var matches = new List<T>();

            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    matches.Add(element);
                }
            }

            return matches;
        }

        public static TSelector CustomMax<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> selector)
            where TSelector : IComparable<TSelector>
        {
            var matches = new List<TSelector>();

            foreach (var element in collection)
            {
                matches.Add(selector(element));
            }

            if (matches.Count < 1)
            {
                return default(TSelector);
            }

            TSelector max = matches[0];
            
            for (int i = 1; i < matches.Count; i++)
            {
                if (matches[i].CompareTo(max) > 0)
                {
                    max = matches[i];
                }
            }

            return max;
        }
    }
}
