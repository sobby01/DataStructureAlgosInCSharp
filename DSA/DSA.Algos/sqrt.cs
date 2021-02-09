using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algos
{
    public class sqrt
    {
        public int FindSqrt(int A)
        {
            if (A == 0)
            {
                return 0;
            }

            ulong min = 0;
            ulong max = (ulong)A / 2;
            while (min <= max)
            {
                ulong mid = min + (max - min) / 2;

                if (mid * mid <= (ulong)A && ((mid + 1) * (mid + 1) > (ulong)A))
                {
                    return (int)mid;
                }
                else if (mid * mid > (ulong)A)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return (int)min;
        }
    }
}
