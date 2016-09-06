using System.Collections.Generic;

namespace ProofOfConcept.Search
{
    public static class LinearSearch<T>
    {
        public static int Search(IEnumerable<T> collection, T value)
        {
            var index = 0;
            foreach(T t in collection)
            {
                if (value.Equals(t)) return index;
                else index++;
            }
            return -1;
        }

        public static int Search(T[] array, T value)
        {
            for(var i = 0; i < array.Length; i++)
            {
                if (value.Equals(array[i])) return i;
            }
            return -1;
        }
    }
}