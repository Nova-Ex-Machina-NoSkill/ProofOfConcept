using System;

namespace ProofOfConcept.Sorting
{
    public static class BubbleSort<T> where T : IComparable
    {
        public static T[] Sort(T[] array)
        {
            var n = array.Length - 2;
            for(var i = 0; i < n; i++)
            {
                var swapped = false;
                for(var j = 0; j < n; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) == 1)
                    {
                        swap(ref array[j], ref array[j + 1]);
                        swapped = true;
                    }
                    if (!swapped) break;
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