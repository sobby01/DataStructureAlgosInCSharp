using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class DominantNumber
    {
        /*
         *  Input: nums = [3, 6, 1, 0]
            Output: 1
            Input: nums = [1, 2, 3, 4]
            Output: -1
            [0,0,3,2]
            Input: nums = [0, 0, 0, 4]
            Output: 3
         */
        public int DominantIndex(int[] nums)
        {
            int dominantIndex = 0;
            int maxSquare = 0;
            int secondMaxSquare = 0;

            for (int indexer = 0; indexer < nums.Length; indexer++)
            {
                if (nums[indexer] >= maxSquare)
                {
                    dominantIndex = indexer;
                }

                if (maxSquare < nums[indexer] * 2)
                {
                    maxSquare = nums[indexer] * 2;
                }
                else if(secondMaxSquare < nums[indexer] * 2)
                {
                    secondMaxSquare = nums[indexer] * 2;
                }
            }

            for (int indexer = 0; indexer < nums.Length; indexer++)
            {
                //if()
            }

            if (nums[dominantIndex] < maxSquare && maxSquare/2 != nums[dominantIndex]) return -1;

            return dominantIndex;
        }
    }
}
