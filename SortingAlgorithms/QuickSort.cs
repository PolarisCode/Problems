using System;

namespace Problem_Solving.SortingAlgorithms
{
    public class QuickSort
    {
        public QuickSort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private void Sort(int[] arr, int start, int end)
        {
            if (start >= end) return;

            var pIndex = Partition(arr, start, end);
            Sort(arr, start, pIndex - 1);
            Sort(arr, pIndex + 1, end);
        }
        //{9,8,7,6,5,4}
        private int Partition(int[] arr, int start, int end)
        {
            var pivot = arr[end];

            var pIndex = start;

            for (int i = start; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                {
                    swap(arr, i, pIndex);
                    pIndex++;
                }
            }

            swap(arr, pIndex, end);

            return pIndex;
        }

        private void swap(int[] arr, int a, int b)
        {
            var tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }
    }
}