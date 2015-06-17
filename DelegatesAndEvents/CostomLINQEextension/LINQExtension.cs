namespace CostomLINQEextension
{
    using System;
    using System.Collections.Generic;

    public static class LinqExtension
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static TSelector Max<TSource, TSelector>(
            this IEnumerable<TSource> colection, 
            Func<TSource, TSelector> selectFunc) where TSelector : IComparable
        {
            var properties = GetProperty(colection, selectFunc);
            var maxValue = default(TSelector);
            foreach (var item in properties)
            {
                if (item.CompareTo(maxValue) == 1)
                {
                    maxValue = item;
                }
            }

            return maxValue;
        }

        private static IEnumerable<TK> GetProperty<T, TK>(this IEnumerable<T> collection, Func<T, TK> selectFunc)
        {
            List<TK> list = new List<TK>();
            foreach (var elelment in collection)
            {
                var currentValue = selectFunc(elelment);
                list.Add(currentValue);
            }

            return list;
        }
    }
}