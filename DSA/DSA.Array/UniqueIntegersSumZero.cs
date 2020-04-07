using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class UniqueIntegersSumZero
    {
        public int[] SumZero(int n)
        {
            int[] sumZeroArray = new int[n];
            if (n == 0)
                return new[] {0};
            int left = 0;
            int right = n - 1;
            for (int indexer = n / 2; indexer > 0; indexer--)
            {
                sumZeroArray[left] = indexer;
                sumZeroArray[right] = -1 * indexer;
                left++;
                right--;
            }

            return sumZeroArray;
        }
    }
}
