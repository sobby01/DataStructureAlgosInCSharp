using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class SortArrayByParity
    {
        //Input: [3,1,2,4]
        //Output: [2,4,3,1]
        //The outputs[4, 2, 3, 1], [2, 4, 1, 3], and[4, 2, 1, 3] would also be accepted.
        //Idea is quick sort, if mod of left side element is 1 and right side 0 it means swap'


        public void Sort(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;

            while (i < j)
            {
                if (arr[i] % 2 < arr[j] % 2)
                {
                    int t = arr[j];
                    arr[j] = arr[i];
                    arr[i] = t;
                }

                if (arr[i] % 2 == 0)
                    i++;
                if (arr[j] % 2 == 1)
                    j--;
            }
        }
    }
}
