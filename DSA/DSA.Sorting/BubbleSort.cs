using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting
{
    public class BubbleSort : ISorting
    {
        public void Sort(int[] arr)
        {
            int size = arr.Length;
            int min = -1;
            int temp = 0;

            for (int indexer = 1; indexer < size - 2; indexer++)
            {
                for (int sortIndex = 0; sortIndex < size - indexer; sortIndex++)
                {
                    if (arr[sortIndex] > arr[sortIndex + 1])
                    {
                        temp = arr[sortIndex];
                        arr[sortIndex] = arr[sortIndex + 1];
                        arr[sortIndex + 1] = temp;
                    }
                }
            }
        }
    }
}
