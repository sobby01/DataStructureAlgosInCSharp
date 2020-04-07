using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class PeakIndexInMountain
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            int start = 0;
            int end = A.Length - 1;

            while (start < end)
            {
                int mid = (start + end) / 2;

                if (A[mid] < A[mid + 1])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            return start;
        }
    }
}
