using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array.SearchAlgos
{
    public class BinarySearch_Iterative
    {
        public int BinarySearch(int[] arr, int x, int l, int r)
        {
            while (r >= l)
            {
                int m = (l + r) / 2;

                if (arr[m] == x)
                {
                    return m;
                }

                if (arr[m] >= x)
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }

            return -1;
        }
    }
}
