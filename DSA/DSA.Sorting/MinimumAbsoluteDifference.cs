using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting
{
    public class MinimumAbsoluteDifference
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            IList<IList<int>> li = new List<IList<int>>();
            Array.Sort(arr);
            int minDiff = Int32.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] < minDiff)
                {
                    minDiff = arr[i + 1] - arr[i];
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] == minDiff)
                {
                    li.Add(new List<int> { arr[i], arr[i + 1] });
                }
            }

            return li;
        }
    }
}
