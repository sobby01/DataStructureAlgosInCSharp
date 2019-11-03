using System;

namespace DSA.Sorting
{
    public class SelectionSort: ISorting
    {
        public void Sort(int[] arr)
        {
            int size = arr.Length;
            int min = -1;
            int temp = 0;
            for (int indexer = 0; indexer < size; indexer++)
            {
                min = indexer;
                //Find Min and then Swap
                for (int minIndexer = indexer + 1; minIndexer < size; minIndexer++)
                {
                    if (arr[min] > arr[minIndexer])
                    {
                        min = minIndexer;
                    }
                }

                //Swap

                temp = arr[indexer];
                arr[indexer] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
