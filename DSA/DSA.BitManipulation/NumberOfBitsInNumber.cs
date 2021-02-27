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
    }
}
