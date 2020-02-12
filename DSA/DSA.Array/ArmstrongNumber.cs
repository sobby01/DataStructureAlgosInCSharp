using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class ArmstrongNumber
    {
        public bool IsArmstrong(int N)
        {
            int length = (int)(Math.Log10(N) + 1);
            var nn = Math.Log10(N);
            int totalSum = 0;
            while (N > 0)
            {
                int currentNum = N % 10;
                totalSum += (int)Math.Pow(currentNum, length);
                N = N / 10;
            }

            if (totalSum == N)
            {
                return true;
            }
            return false;


        }
    }
}
