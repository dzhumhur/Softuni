namespace Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static T FirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            foreach (var element in collection)
            {
                if (condition(element))
                {
                    return element;                   
                }
            }

            return default(T);
        }

        public static IEnumerable<T> TakeWhile<T> (this IEnumerable<T> collection, Func<T, bool> condition)
        {
            var matches = new List<T>();

            foreach (var element in collection)
            {
                if (condition(element))
                {
                    matches.Add(element);
                }
            }
            
            return matches.OrderBy(c => c);
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> condition)
        {
            foreach (var element in collection)
            {
                condition(element);
            }
        }

    }
}
