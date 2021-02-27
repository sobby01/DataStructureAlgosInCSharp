using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BitManipulation
{
    public class NumberOfBitsInNumber
    {
        public int Solve(int num)
        {
            int x = (int)Math.Log(num, 2.0) + 1;

            return x;
        }

        public int SolveBitWise(int num)
        {
            int count = 0;
            while (num != 0)
            {
                count++;
                num >>= 1;
            }

            return count;
        }
    }
}
