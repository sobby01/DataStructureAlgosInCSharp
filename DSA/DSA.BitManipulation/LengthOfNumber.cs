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
    }
}
