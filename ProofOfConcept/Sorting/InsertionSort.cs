using System;

namespace ProofOfConcept.Sorting
{
    public static class InsertionSort<T> where T : IComparable
    {
        public static T[] Sort(T[] array)
        {
            var n = array.Length - 2;
            for(var i = 0; i < n; i++)
            {
                if (array[i].CompareTo(array[i + 1]) == 1)
                {
                    swap(ref array[i], ref array[i + 1]);
                    for(var j = i; j > 0; j--)
                    {
                        if (array[j].CompareTo(array[j - 1]) == -1) swap(ref array[j], ref array[j - 1]);
                        else break;
                    }
                }
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