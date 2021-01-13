using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class MinimumWatchTV
    {
        public string solve(List<int> A, List<int> B)
        {

            int[] arr1 = A.ToArray();
            Array.Sort(arr1);

            int[] arr2 = B.ToArray();
            Array.Sort(arr2);

            int r = 1;
            int i = 1; int j = 0; int totalTv = 1;

            while (i < A.Count && j < A.Count)
            {
                if (arr1[i] <= arr2[j])
                {
                    totalTv++;
                    i++;
                }
                else if (arr1[i] > arr2[j])
                {
                    totalTv--;
                    j++;
                }

                if (totalTv > r)
                    r = totalTv;

            }

            if (r <= 2)
                return "Yes";
            else
                return "No";
        }
    }
}
