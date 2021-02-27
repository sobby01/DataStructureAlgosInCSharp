using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BitManipulation
{
    public class NumberOf1Bits
    {
        public int NumSetBits(long a)
        {
            int count = 0;
            while(a > 0)
            {
                if((a & 1) == 1)
                {
                    count++;
                }

                a = a >> 1;
            }

            return count;
        }
    }
}
