using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    public class FibonacciWithMemoization
    {
        public int CalculateFib(int n)
        {
            return CalculateRecursive(new int[n + 1], n);
        }

        public int CalculateRecursive(int[] memo, int n)
        {
            if (n < 2)
                return 1;

            if (memo[n] != 0)
                return memo[n];

            memo[n] =  CalculateRecursive(memo, n - 1) + CalculateRecursive(memo, n - 2);

            return memo[n];
        }

    }
}
