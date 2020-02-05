using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    //Explaination
    //[0,1,0,2,1,0,1,3,2,1,2,1]

    //left max array:
    //0 1,1,2,2,2,2,3,3,3,3,3 max of current element from left and previous of this

    //right max array: max of current from right and next of this.
    //3, 3, 3,3 ,3 ,3 ,3 , 3, 2, 2, 2,1

    //0 1 0 2 1 0 1 3 2 1 2 1 : Array
    //-----------------------
    //0 1 1 2 2 2 2 3 3 3 3 3 : leftMax
    //3 3 3 3 3 3 3 3 2 2 2 1 : rightMax
    //-----------------------
    //0-0 = 0
    //1-1 = 0
    //1-0 = 1
    //2-2 = 0
    //2-1 = 1
    //2-0 = 2
    //2-1 = 1
    //3-3 = 0
    //2-2 = 0
    //2-1 = 1
    //2-2 = 0
    //1-1 = 0
    //Ans :6

    public class RainTrapWater
    {
        public int TrapWater(int[] height)
        {
            int totalWater = 0;

            if (height != null && height.Any())
            {
                var length = height.Length;
                int[] leftMax = new int[length];
                int[] rightMax = new int[length];
                leftMax[0] = height[0];

                for (int i = 1; i < length; i++)
                {
                    leftMax[i] = Math.Max(height[i], leftMax[i - 1]);
                }

                rightMax[length - 1] = height[length - 1];

                for (int i = length - 2; i >= 0; i--)
                {
                    rightMax[i] = Math.Max(height[i], rightMax[i + 1]);
                }

                for (int i = 1; i < length - 1; i++)
                {
                    totalWater += Math.Min(leftMax[i], rightMax[i]) - height[i];
                }
            }

            return totalWater;
        }
    }
}
