using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BitManipulation
{
    public class LengthOfNumber
    {
        public int GetLength(int number)
        {
            int l = (int)Math.Log10(number) + 1;
            return l;
        }

        public int GetLengthByLoop(int number)
        {
            int count = 0;
            while (number != 0)
            {
                number = number / 10;
                count++;
            }
            return count;
        }
    }
}
