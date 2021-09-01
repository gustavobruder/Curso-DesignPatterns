using System.Collections.Generic;

namespace Design.Patterns.Singletons.Common
{
    public static class ChuckExtensions
    {
        public static IEnumerable<IList<T>> ToChunks<T>(this IEnumerable<T> items, int size)
        {
            var current = new List<T>(size);
            foreach (var item in items)
            {
                current.Add(item);
                if (current.Count < size)
                    continue;

                yield return current;
                current = new List<T>(size);
            }

            if (current.Count > 0)
                yield return current;
        }
    }
}