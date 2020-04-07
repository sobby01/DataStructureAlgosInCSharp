using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    /*
     * Given a positive integer n and you can do operations as follow:

If n is even, replace n with n/2.
If n is odd, you can replace n with either n + 1 or n - 1.
What is the minimum number of replacements needed for n to become 1?
Input:8
Output:3
Explanation:
8 -> 4 -> 2 -> 1

     */
    public class IntegerReplacement
    {
        int ans = Int32.MaxValue;
        public int integerReplacement(int n)
        {

            int n1 = 123;
            int length = (int)(Math.Log10(n1) + 1);
            dfs(n, 0);
            return ans;
        }

        public void dfs(long n, int counter)
        {
            if (n == 1)
            {
                ans = Math.Min(ans, counter);
                return;
            }
            if (n % 2 == 0)
            {
                n = n / 2;
                dfs(n, counter + 1);
            }
            else
            {
                if(n < Int32.MaxValue)
                    dfs(n + 1, counter + 1);
                if (n > Int32.MinValue)
                    dfs(n - 1, counter + 1);
            }
        }

        public int Replacement(int n)
        {
            int replacement = 0;
            if (n <= 1) return 0;
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    if (n <= 3 || ((n-1) %2)==0)
                    {
                        n = n - 1;
                    }
                    else
                    {
                        n = n + 1;
                    }
                }

                

                replacement = replacement + 1;
            }
            return replacement;
        }
    }
}
