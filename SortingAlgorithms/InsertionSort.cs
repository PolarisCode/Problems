using System;

namespace Problem_Solving.SortingAlgorithms
{
    public class InsertionSort
    {
        public InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];

                while (i > 0 && arr[i - 1] > current)
                {
                    arr[i] = arr[i - 1];
                    i--;
                }

                arr[i] = current;
            }
        }
    }

}