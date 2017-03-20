namespace OOP___Homework3.Extentions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerable
    {
        public static double Sum <T>(this IEnumerable<T> arr) where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            var array = arr.Select(x => Convert.ToDouble(x));

            double result = 0;

            foreach (var item in array)
            {
                result += item;
            }

            return result;
        }

        public static long Product<T>(this IEnumerable<T> arr) where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            var array = arr.Select(x => Convert.ToDouble(x));
            long result = 1L;
            foreach (var item in array)
            {
                result *= (long)item;
            }
            return result;
        }

        public static double Min<T>(this IEnumerable<T> arr) where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            var array = arr.Select(x => Convert.ToDouble(x));
            var result = double.MaxValue;

            foreach (var item in array)
            {
                if (item < result)
                {
                    result = item;
                }
            }

            return result;
        }

        public static double Max<T>(this IEnumerable<T> arr) where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            var array = arr.Select(x => Convert.ToDouble(x));
            var result = double.MinValue;

            foreach (var item in array)
            {
                if (item > result)
                {
                    result = item;
                }
            }

            return result;
        }

        public static double Average<T>(this IEnumerable<T> arr) where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            var array = arr.Select(x => Convert.ToDouble(x));
            var result = 0D;

            foreach (var item in array)
            {
                result += item;
            }

            result /= array.Count();
            return result;
        }
    }
}
