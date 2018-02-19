using System;

namespace Problem_Solving.SortingAlgorithms
{
    public class SelectionSort
    {
        public SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var minElement = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minElement] > arr[j])
                    {
                        minElement = j;
                    }
                }

                var swapVal = arr[i];
                arr[i] = arr[minElement];
                arr[minElement] =swapVal;
            }
        }
    }

}