using System.Collections.Generic;

namespace EnableNullable
{
    public static class NullableEnabled

    {
        public static IEnumerable<T> TestNullable<T>(this IEnumerable<T> enumerable)
        {
            return enumerable;
        }
    }
}