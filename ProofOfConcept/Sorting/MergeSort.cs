using System;

namespace ProofOfConcept.Sorting
{
    public static class MergeSort<T> where T : IComparable
    {
        private static T[] unsortedArray;
        private static T[] sortedArray;

        public static T[] Sort(T[] array)
        {
            unsortedArray = array;
            sortedArray = new T[array.Length];
            sort(0, array.Length - 1);
            return sortedArray;
        }

        private static void sort(int left, int right)
        {
            var mid = 0;
            if (left < right)
            {
                mid = (left + right) / 2;
                sort(left, mid);
                sort(mid + 1, right);
                merge(left, mid, right);
            }
        }

        private static void merge(int left, int mid, int right)
        {
            int i, j, k;
            for(i = left, j = mid + 1, k = left; i <= mid && j <= right; k++)
            {
                if (unsortedArray[i].CompareTo(unsortedArray[j]) == 1) sortedArray[k] = unsortedArray[j++];
                else sortedArray[k] = unsortedArray[i++];
            }
            while (i <= mid) sortedArray[k++] = unsortedArray[i++];
            while (j <= right) sortedArray[k++] = unsortedArray[j++];
        }
    }
}