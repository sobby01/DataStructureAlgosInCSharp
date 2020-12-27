using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    public class HouseRobber
    {

        /// <summary>
        /// odd : 7 : 0,2,4,6 : 1,3,5,7
        /// Even : 8 : 0,2,4,6,8 : 1,3,5,7
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Rob(int[] nums)
        {
            int firstPointer = 0; int firstMaxVal = 0;
        
            int secondPointer = 0; int secondMaxVal = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(i%2 == 0)
                {
                    firstMaxVal += nums[i];
                }
                else
                {
                    secondMaxVal += nums[i];
                }
                
            }

            return Math.Max(firstMaxVal, secondMaxVal);

        }
    }
}
