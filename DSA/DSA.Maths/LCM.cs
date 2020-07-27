using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Maths
{
    public class LCM
    {
        // compute LCM from 1 to n
        public int Compute(int[] numbers)
        {
            int lcm = 0;
            int maxValue = FindMax(numbers);

            int x = 2;
            
            while (x <= maxValue)
            {

            }

            return lcm;
        }

        public int FindMax(int[] a1)
        {
            int max_value = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                if (max_value < a1[i])
                {
                    max_value = a1[i];
                }
            }

            return max_value;
        }
    }
}
