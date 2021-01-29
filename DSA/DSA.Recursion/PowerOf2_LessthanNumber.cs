using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class PowerOf2_LessthanNumber
    {
        public int highestPowerof2(int n)
        {
            int res = 0;
            for (int i = n; i >= 1; i--)
            {
                // If i is a power of 2 
                if ((i & (i - 1)) == 0)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
    }
}
