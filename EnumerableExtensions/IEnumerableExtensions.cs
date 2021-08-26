using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstOrDefaultValue
{
    public static class IEnumerableExtensions
    {
        public static T FirstOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate, T defaultValue)
        {
            T value = source.FirstOrDefault(predicate);

            return GetDefaultValue(defaultValue, value);
        }

        public static T LastOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate, T defaultValue)
        {
            T value = source.LastOrDefault(predicate);

            return GetDefaultValue(defaultValue, value);
        }

        public static T SingleOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate, T defaultValue)
        {
            T value = source.SingleOrDefault(predicate);

            return GetDefaultValue(defaultValue, value);
        }

        private static T GetDefaultValue<T>(T defaultValue, T value) => EqualityComparer<T>.Default.Equals(value, default) ? defaultValue : value;

    }
        

}
