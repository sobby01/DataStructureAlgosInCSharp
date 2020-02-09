using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class MaxSubArray
    {
        public int maxSubArray(int[] nums)
        {
            if (nums.Length < 0)
            {
                return -1;
            }
            else if (nums.Length == 1)
            {
                return nums[0];
            }
            int maxSubArray = 0;
            int LargestMaxSubArray = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if((nums[i] > maxSubArray && (nums[i] + maxSubArray < nums[i])) || i == 0)
                {
                    maxSubArray = nums[i];
                }
                else
                {
                    maxSubArray = nums[i] + maxSubArray;
                }

                LargestMaxSubArray = Math.Max(maxSubArray, LargestMaxSubArray);

            }

            return LargestMaxSubArray;
        }
    }
}
