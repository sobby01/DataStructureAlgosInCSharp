using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algos
{
    public class KadaneAlgo
    {
        public int MaxGlobal(int[] arr)
        {
            int maxCurrent = arr[0];
            int maxMain = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                maxCurrent = Math.Max(arr[i], maxCurrent + arr[i]);

                if(maxCurrent > maxMain)
                {
                    maxMain = maxCurrent;
                }
            }

            return maxMain;
        }
    }
}
