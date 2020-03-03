using System;
using System.Collections.Generic;

namespace NonNullable
{
    public static class NonNullable

    {
        public static IEnumerable<T> TestNonNullable<T>(this IEnumerable<T> enumerable)
        {
            return enumerable;
        }
    }
}
