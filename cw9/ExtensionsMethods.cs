using System;
using System.Collections;
using System.Collections.Generic;

namespace cw9
{
    public static class ExtensionsMethods
    {
        public static bool isPjatkIndex(this string str)
        {
            return str[0] == 's' && str.Length == 5;
        }

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> enums, Func<T, bool> where)
        {
            var result = new List<T>();
            foreach (var i in enums)
            {
                if (where(i)) result.Add(i);
            }
            return result;
        }
    }
}