using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class FibonacciNumber
    {
        public int Fib(int N)
        {
            if (N <= 0)
                return 0;
            else if (N == 1)
                return 1;
            else
            {
                int sum = Fib(N - 1) + Fib(N - 2);
                return sum;
            }
        }
    }
}
