using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BitManipulation
{
    public class InvertBitsOfNumber
    {
        public int invertBits(int num){
           
           int x = (int)Math.Log(num, 2.0) + 1;

            int n = num;
            for (int i = 0; i < x; i++)
            {
                n = (n ^ (1 << i));
            }

            return num;
        }
    }
}
