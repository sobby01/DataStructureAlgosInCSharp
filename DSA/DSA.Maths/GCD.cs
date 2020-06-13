using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Maths
{
    public class GCD
    {
        public int AllCommonDivisors(int a, int b)
        {
            int n = GCDCalculator(a, b);
            int result = 0;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
					// This is the divisor

                    if (n / i == i)
                    {
                        result += 1;
                    }
                    else
                    {
                        result += 2;
                    }

                }
            }

            return result;
        }

        int GCDCalculator(int a, int b)
        {
            if (a == 0)
                return b;

            return GCDCalculator(b % a, a);
        }

        public int SmallestDivisor(int n)
        {
            if (n % 2 == 0)
            {
                return 2;
            }

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return i;
                }
            }

            return n;
        }
    }
}
