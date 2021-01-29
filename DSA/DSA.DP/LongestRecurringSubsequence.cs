using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    public class LongestRecurringSubsequence
    {
        public int findLongestRepeatingSubSeq(string str)
        {
            int n = str.Length;
            int[,] dp = new int[n + 1, n + 1];

            for(int i =1; i <= str.Length; i++)
            {
                for(int j =1; j <= str.Length; j++)
                {
                    if(str[i-1] == str[j-1] && i != j)
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[n,n];
        }
    }
}
