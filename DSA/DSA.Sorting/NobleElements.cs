using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting
{
    public class NobleElements
    {
        public int GetNobleElement(int[] arr)
        {
            int element = -1;

            Array.Sort(arr);

            int n = arr.Length;

            for(int i = 0; i < n; i++)
            {
                if (arr[i] == arr[i + 1])
                    continue;

                if (arr[i] == n - i - 1)
                    return arr[i];
            }

            return element;

        }
    }
}
