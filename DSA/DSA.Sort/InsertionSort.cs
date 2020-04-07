using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace DSA.Sort
{
    /// <summary>
    /// Divide the set into two subsets
    /// </summary>
    public class InsertionSort : ISorting
    {
        public void Sort(int[] arr)
        {
            int size = arr.Length;
            int temp = -1;
            int currentIndexer = 0;
            for (int indexer = 1; indexer < size; indexer++)
            {
                currentIndexer = indexer;
                for (int leftSubset = indexer -1; leftSubset >= 0; leftSubset--)
                {
                    if (arr[currentIndexer] < arr[leftSubset])
                    {
                        temp = arr[leftSubset];
                        arr[leftSubset] = arr[currentIndexer];
                        arr[currentIndexer] = temp;
                        currentIndexer--;
                    }

                    
                }
            }
        }
    }
}
