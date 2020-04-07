using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure.SearchAlgos
{
    public class BinarySearch_Recursive
    {
        public int BinarySearch(int[] arr, int x, int l, int r)
        {
            int minValue = FindMin(l, r, arr, x);

            if (r >= l)
            {
                int m = (l + r) / 2;

                if (arr[m] == x)
                    return m;

                if (arr[m] >= x)
                {
                    BinarySearch(arr, x, 0, m - 1);
                }

                return BinarySearch(arr, x, m + 1, r);
            }

            return -1;
        }

        int FindMin(int lo, int hi, int[] arr,int X)
        {
            int mid = 0;

            mid = lo + ((hi - lo) / (arr[hi] - arr[lo])) * (X - arr[lo]);

            return mid;
        }
    }
}
