using System;
using System.Collections.Generic;

namespace Tests.Helpers
{
    public class Comparer
    {
        public static Comparer<U> Get<U>(Func<U, U, bool> func)
        {
            return new Comparer<U>(func);
        }
    }

    public class Comparer<T> : Comparer, IEqualityComparer<T>
    {
        private Func<T, T, bool> compFunc;

        public Comparer(Func<T, T, bool> func)
        {
            compFunc = func;
        }

        public bool Equals(T x, T y)
        {
            return compFunc(x, y);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }
    }
}