using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class PeekInMountainArray
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums.Length < 2)
            {
                return 0;
            }

            for (int indexer = 1; indexer <= nums.Length-1; indexer++)
            {
                if (nums[indexer - 1] < nums[indexer])
                {
                    if (indexer + 1 < nums.Length && nums[indexer] > nums[indexer + 1])
                        return indexer;

                    if (indexer == nums.Length-1)
                        return indexer;
                }
            }

            return 0;
        }
    }
}
