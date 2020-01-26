using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonComparer.Helpers
{
    public static class LinqExtensions
    {
        //Distinct by inner property and overrite by last element
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> items, Func<T, TKey> property)
        {
            return items.GroupBy(property).Select(x => x.Last());
        }
    }
}
