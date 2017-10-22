using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Multi_Account
{
    static class Extensions
    {
        public static IEnumerable<T> OfType<T>(this IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                if (item is T)
                    yield return (T)item;
            }
        }

        public static bool InRange(this int number, int min, int max)
        {
            return min <= number && number <= max;
        }
    }
}
