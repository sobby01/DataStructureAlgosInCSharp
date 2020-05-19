using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class Factorial
    {
        public int FindFactorial_iterative(int num)
        {
            if (num >= 0 && num < 2)
            {
                return 1;
            }
            else if (num < 0)
            {
                return 0;
            }
            else
            {
                int fact = 1;
                for (int i = 1; i <= num; i++)
                {
                    fact = fact * i;
                }

                return fact;
            }
        }


        public int FindFactorial_recursive(int num)
        {
            if (num < 2)
            {
                return 1;
            }

            return num * FindFactorial_recursive(num-1);
        }
    }
}
