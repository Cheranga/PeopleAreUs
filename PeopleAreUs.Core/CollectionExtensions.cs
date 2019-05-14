using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PeopleAreUs.Core
{
    public static class CollectionExtensions
    {
        public static List<T> SortCollection<T>(this IEnumerable<T> collection, Func<T, object> orderBy, ListSortDirection direction) where T : class
        {
            if (collection == null)
            {
                return default(List<T>);
            }

            if (direction == ListSortDirection.Ascending)
            {
                return collection.OrderBy(orderBy).ToList();
            }

            return collection.OrderByDescending(orderBy).ToList();
        }
    }
}