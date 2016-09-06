using System;
using System.Collections.Generic;
using System.Linq;

namespace ProofOfConcept.Search
{
    public static class BinarySearch<T> where T : IComparable<T>
    {
        public static int Search(T[] array, T value)
        {
            var left = 0;
            var right = array.Length - 1;
            var mid = 0;
            var result = 0;

            while (right >= left)
            {
                mid = left + (right - left) / 2;
                result = value.CompareTo(array[mid]);
                if (result == 0) return mid;
                else if (result == 1) left = mid + 1;
                else right = mid - 1;
            };
            return -1;
        }

        public static int Search(IEnumerable<T> array, T value)
        {
            return Search(array.ToArray(), value);
        }
    }
}