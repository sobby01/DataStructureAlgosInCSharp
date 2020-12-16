using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class SumOfNNaturalNumbers
    {
        public int SumN(int n)
        {
            if (n == 0)
                return 0;

            int val = SumN(n - 1);

            return n + val;
        }
    }
}
