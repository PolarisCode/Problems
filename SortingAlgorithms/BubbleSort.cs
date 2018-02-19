using System;

namespace Problem_Solving.SortingAlgorithms
{
    public class BubbleSort
    {
        public BubbleSort(int[] arr)
        {
            for (int k = 1; k < arr.Length; k++)
            {
                bool swap = false;

                for (int i = 0; i <= arr.Length - k - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var minVal = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = minVal;
                        swap = true;
                    }
                }

                // if no elemets were swaped then stop cycle
                if (!swap)
                    break;
            }
        }
    }
}