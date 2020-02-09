using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array.SearchAlgos
{
    public class BinarySearch_Recursive
    {
        public int BinarySearch(int[] arr, int x, int l, int r)
        {
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
    }
}
