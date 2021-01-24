using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class KthSmallestNumber
    {
        public int kthsmallest(List<int> A, int B)
        {

            int[] arr = A.ToArray();

            return arr[B - 1];
        }
    }
}
