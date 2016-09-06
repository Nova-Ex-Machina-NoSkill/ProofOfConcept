using System;

namespace ProofOfConcept.Sorting
{
    public static class SelectionSort<T> where T : IComparable
    {
        public static T[] Sort(T[] array)
        {
            var n = array.Length - 1;
            for(var i = 0; i < n - 1; i++)
            {
                var min = i;
                for (var j = i + 1; j < n; j++)
                {
                    if (array[min].CompareTo(array[j]) == 1) min = j;
                }
                if (min != i) swap(ref array[i], ref array[min]);
            }
            return array;
        }

        private static void swap(ref T x, ref T y)
        {
            var tmp = x;
            x = y;
            y = tmp;
        }
    }
}