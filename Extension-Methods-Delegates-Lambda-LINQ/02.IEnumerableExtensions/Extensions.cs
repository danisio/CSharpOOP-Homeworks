namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable, IConvertible
        {
            if (collection.Count<T>() == 0)
            {
                throw new ArgumentException();
            }

            T min = collection.First();
            foreach (var element in collection)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
                    where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException();
            }

            T max = collection.First();
            foreach (var element in collection)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> collection)
            where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException();
            }

            decimal average = 0.0m;
            average = (dynamic)collection.Sum() / (decimal)collection.Count();
            
            return average;
        }

        public static T Sum<T>(this IEnumerable<T> collection)
            where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException();
            }

            dynamic sum = 0;
            foreach (var element in collection)
            {
                sum += element;
            }

            return sum;
        }

        public static dynamic Product<T>(this IEnumerable<T> collection)
            where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException();
            }

            dynamic sum = 1;
            foreach (T item in collection)
            {
                sum *= item;
            }

            return sum;
        }
    }
}
