using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    public class CoinChange
    {
        public int GetCount(int[] coins, int n, int sum)
        {
            if (sum == 0)
                return 1;
            if (n == 0)
                return 0;

            int res = GetCount(coins, n - 1, sum);

            if(coins[n-1] <= sum)
            {
                res = res + GetCount(coins, n, sum - coins[n-1]);
            }

            return res;
        }
    }
}
