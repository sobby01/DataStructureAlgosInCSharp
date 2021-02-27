using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    /*
     * Given N items with weights W[0..n-1], values V[0..n-1] and a knapsack with capacity C, 
     * select the items such that:
     * The sum of weights taken into the knapsack is less than or equal to C.
     * The sum of values of the items in the knapsack is maximum among all the possible combinations.
     * Input: N = 4, C = 15, V[]= {10, 10, 12, 18}, W[]= {2, 4, 6, 9}
       Output:
       Items taken into the knapsack are
       1 1 0 1
       Maximum profit is 38
     * */
    public class Knapsack01
    {

        public int Solve_Recursively(int[] val, int[] w, int c, int n)
        {
            if (n == 0 || c == 0)
                return 0;

            if(w[n] <= c)
            {
                return Math.Max(val[n-1] + Solve_Recursively(val, w, c-w[n], n - 1), Solve_Recursively(val, w, c, n - 1));
            }
            else
            {
                return Solve_Recursively(val, w, c, n - 1);
            }
        }

        public int Solve_Memo(int[] val, int[] w, int c, int n)
        {
            if (n == 0 || c == 0)
                return 0;

            if (w[n] <= c)
            {
                return Math.Max(val[n - 1] + Solve_Memo(val, w, c - w[n], n - 1), Solve_Memo(val, w, c, n - 1));
            }
            else
            {
                return Solve_Memo(val, w, c, n - 1);
            }
        }

    }
}
