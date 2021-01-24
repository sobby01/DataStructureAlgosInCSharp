using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting
{
    public class WaveArray
    {
        public List<int> wave(List<int> A)
        {
            if (A.Count <= 1)
                return A;
            int[] arr = A.ToArray();

            Array.Sort(arr);

            for(int i = 1; i < arr.Length; i=i+2)
            {
                if((i & 1) == 1)
                {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                }
                else
                {
                    continue;
                }
            }

            return new List<int>(arr);

        }
    }
}
