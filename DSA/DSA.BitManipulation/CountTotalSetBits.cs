using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BitManipulation
{
    public class CountTotalSetBits
    {
        public int[] CountBits(int num)
        {
            int[] nums = new int[num + 1];
            nums[0] = 0;

            if(num == 1)
            {
                nums[1] = 1;
            }
            int cNum = num / 2;
            for (int i = 1; i <= cNum; i++)
            {
                if (i == 1 || i == 2)
                {
                    nums[i] = 1;
                }
                if (i * 2 <= num)
                {
                    nums[i * 2] = nums[i];
                }
                if (i * 2 + 1 <= num)
                {
                    nums[i * 2 + 1] = nums[i] + 1;
                }    
            }

            return nums;
        }


        public int CountBitsHalfN(int num)
        {
            int[] nums = new int[num/2 + 1];
            nums[0] = 0;
            int countBits = 0;
            if (num >= 1)
            {
                if(num > 1)
                    nums[1] = 1;
                countBits++;
            }
            int cNum = num / 2;
            for (int i = 1; i <= cNum; i++)
            {
                if (i * 2 <= num)
                {
                    if(i*2 <= cNum)
                    {
                        countBits += nums[i * 2] = nums[i];
                    }
                    else
                    {
                        countBits += nums[i];
                    }
                    
                }
                if (i * 2 + 1 <= num)
                {
                    if (i * 2+1 <= cNum)
                    {
                        countBits += nums[i * 2 + 1] = nums[i] + 1;
                    }
                    else
                    {
                        countBits += nums[i] + 1;
                    }
                }
            }

            return countBits;
        }

        public int solve(int A)
        {
            int count = 0;
            if (A == 0)
                return 0;
            int x = PowerOf2(A);
            int bitUptoPowerOf2 = x * (1 << (x - 1));
            int maxBitsAfterX = A - (1 << x) + 1;

            count = bitUptoPowerOf2 + maxBitsAfterX + solve(A - (1 << x));

            return count % 1000000007;
        }

        private int PowerOf2(int n)
        {
            int i = 0;
            while ((1 << i) <= n)
            {
                i++;
            }
            return i - 1;
        }
    }
}
