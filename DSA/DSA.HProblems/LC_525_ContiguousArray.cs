using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashingProblems
{
    public class LC_525_ContiguousArray
    {
        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int maxLength = 0;
            int sum = 0;
            map.Add(0, -1); // it is required for first two elements otherwise it will be missed.
            for (int i =0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    sum += -1;
                }
                else
                {
                    sum += 1;
                }

                if (map.ContainsKey(sum))
                {
                    maxLength = Math.Max(maxLength, i - map[sum]);
                }
                else
                {
                    map.Add(sum, i);
                }
            }

            return maxLength;
        }
    }
}
