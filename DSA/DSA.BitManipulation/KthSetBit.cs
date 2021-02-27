using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BitManipulation
{
    public class KthSetBit
    {
        public void KthBitUsingLeftShift(int n, int k)
        {
            if(k > 0)
            {
                if ((n & (1 << k - 1)) == 1)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }

        public void KthBitUsingRightShift(int n, int k)
        {
            if ((1 & (n >> k - 1)) == 1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
