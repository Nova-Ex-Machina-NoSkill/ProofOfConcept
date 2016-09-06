using System;

namespace ProofOfConcept.Sorting
{
    public static class QuickSort<T> where T : IComparable
    {
        private static T[] a;

        public static T[] Sort(T[] array)
        {
            a = array;
            quickSort(0, array.Length - 1);
            return a;
        }

        private static void quickSort(int left, int right)
        {
            if (right - left > 0)
            {
                var pivot = a[right];
                var partitionPoint = partition(left, right, pivot);
                quickSort(left, partitionPoint - 1);
                quickSort(partitionPoint + 1, right);
            }
        }

        private static int partition(int left, int right, T pivot)
        {
            var leftPointer = left - 1;
            var rightPointer = right;
            while(true)
            {
                while (pivot.CompareTo(a[++leftPointer]) == 1) ;
                while (rightPointer > 0 && pivot.CompareTo(a[--rightPointer]) == -1) ;
                if (leftPointer < rightPointer) swap(leftPointer, rightPointer);
                else break;
            }
            swap(leftPointer, right);
            return leftPointer;
        }

        private static void swap(int x, int y)
        {
            var tmp = a[x];
            a[x] = a[y];
            a[y] = tmp;
        }
    }
}