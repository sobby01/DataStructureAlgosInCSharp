using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    public class FibWithTabulation_Bottomup
    {
        public int CalculateFib(int n)
        {
            int[] dpArray = new int[n + 1];

            dpArray[0] = 1;
            dpArray[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dpArray[i] = dpArray[i - 1] + dpArray[i - 2];
            }

            return dpArray[n];
        }

    }
}
