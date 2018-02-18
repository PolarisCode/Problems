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

            // if element count<2 then array already is sorted
            if (n < 2)
                return;

            // break initial array into 2 parts
            int middle = n / 2;

            int i = 0;

            int[] leftArr = new int[middle]; // specify left part
            int[] rightArr = new int[n - middle]; // specify right part

            // populate left array
            for (i = 0; i < middle; i++)
            {
                leftArr[i] = arr[i]; 
            }

            // populate right array;
            i = 0;
            for (int j = middle; j < n; j++)
            {
                rightArr[i] = arr[j];
                i++;
            }

            // go through each array trying to break them once again
            Sort(leftArr);
            Sort(rightArr);

            // merge sorted left and right array
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