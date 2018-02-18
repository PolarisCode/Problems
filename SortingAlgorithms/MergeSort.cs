using System;

namespace Problem_Solving.SortingAlgorithms
{
    public class MergeSort
    {
        public MergeSort(int[] arr)
        {
            Sort(arr);
        }

        public void Sort(int[] arr)
        {
            int n = arr.Length;

            if (n < 2)
                return;

            int middle = n / 2;

            int i = 0;

            int[] leftArr = new int[middle];
            int[] rightArr = new int[n - middle];

            for (i = 0; i < middle; i++)
            {
                leftArr[i] = arr[i];
            }

            i = 0;
            for (int j = middle; j < n; j++)
            {
                rightArr[i] = arr[j];
                i++;
            }

            Sort(leftArr);
            Sort(rightArr);

            Merge(leftArr, rightArr, arr);
        }

        public void Merge(int[] L, int[] R, int[] A)
        {
            int i = 0; // index in L array
            int j = 0; // index in R array
            int k = 0; // index in result array

            while (i < L.Length && j < R.Length)
            {
                if (L[i] <= R[j])
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < L.Length)
            {
                A[k] = L[i];
                k++;
                i++;
            }

            while (j < R.Length)
            {
                A[k] = R[j];
                k++;
                j++;
            }
        }
    }
}