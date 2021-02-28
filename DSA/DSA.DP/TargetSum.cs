using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    public class TargetSum
    {
        public int FindTargetSumWays(int[] nums, int S)
        {
            int range = 0;
            int count = 0;

            if (nums.Length == 1)
            {
                if (nums[0] < S)
                    return 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    count++;
                range += nums[i];
            }

            if (range < S)
                return 0;

            if ((range + S) % 2 != 0)
                return 0;


            int targetSum = (range + S) / 2;

            //Now find all the subsets of targetSum
            return countSubsets(nums, targetSum, count);

        }

        private int countSubsets(int[] nums, int targetSum, int count)
        {

            int[,] dp = new int[nums.Length + 1, targetSum + 1];

            for (int i = 0; i <= nums.Length; i++)
            {
                dp[i, 0] = 1;
            }

            for (int i = 1; i <= targetSum; i++)
            {
                dp[0, i] = 0;
            }

            for (int i = 1; i <= nums.Length; i++)
            {

                for (int j = 1; j <= targetSum; j++)
                {

                    if (nums[i - 1] == 0)
                        dp[i, j] = dp[i - 1, j];
                    else if (nums[i - 1] > j)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j] + dp[i - 1, j - nums[i - 1]];
                    }
                }
            }

            return (int)(Math.Pow(2, count) * dp[nums.Length, targetSum]);

        }
    }
}
