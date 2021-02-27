using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BitManipulation
{
    public class OddManOut
    {
        public int getOddManOut(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result = result ^ arr[i];
            }
            return result;
        }
    }
}
