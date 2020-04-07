using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class SquareOfSortedArray
    {
        public int[] SortedSquares(int[] A)
        {
            int start = 0;
            int end = A.Length - 1;
            int i = end;
            int[] sortedArray = new int[A.Length];
            for (int indexer = 0; indexer < A.Length; indexer++)
            {
                int pow1 = A[start] * A[start];
                int pow2 = A[end] * A[end];
                if (pow1 > pow2)
                {
                    sortedArray[i] = pow1;
                    start++;
                    i--;
                }
                else
                {
                    sortedArray[i] = pow2;
                    end--;
                    i--;
                }
            }

            return sortedArray;
        }
    }
}
