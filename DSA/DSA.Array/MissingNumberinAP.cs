using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    /*
     *  Input: arr = [5,7,11,13]
        Output: 9
        Explanation: The previous array was [5,7,9,11,13].
     */
    public class MissingNumberinAP
    {
        public int MissingNumber(int[] arr)
        {
            int len = arr.Length;
            //Formula : n/2(ft + lt);
            int expectedOutput = (int)((len+1)*(arr[0] + arr[len - 1])/2);

            int realInput = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                realInput += arr[i];
            }

            return expectedOutput- realInput;
        }
    }
}
