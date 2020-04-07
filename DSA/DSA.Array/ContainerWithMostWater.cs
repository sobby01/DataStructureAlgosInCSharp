using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int mArea = 0;

            //Input: [1,8,6,2,5,4,8,3,7]
            //Output: 49
            if (height.Length > 0)
            {
                int leftPointer = 0;
                int rightPointer = height.Length - 1;

                while(leftPointer < rightPointer)
                {
                    mArea = Math.Max(mArea, Math.Min(height[leftPointer], height[rightPointer]) * (rightPointer - leftPointer));

                    if (height[rightPointer] > height[leftPointer])
                    {
                        leftPointer++;
                    }
                    else
                    {
                        rightPointer--;
                    }
                }
            }

            return mArea;
        }
    }
}
