using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    /*
    Given an array A of integers, find the maximum of j-i subjected to the constraint of A[i] <= A[j]
    If there is no possible solution return -1
    A : [3 5 4 2]
    output : 2 for the pair (3,4)
    */
    public class MaxDistance
    {
        public int Calculate(int[] arr)
        {
            int[] originalArray = (int[])arr.Clone();
            Array.Sort(arr);
            int n = arr.Length;
            int[] originalIndexes = new int[n];
            for(int i = 0; i < n; i++)
            {
                originalIndexes[i] = Array.IndexOf(originalArray, arr[i]);
            }

            int min = Int16.MaxValue;
            int ans = 0;
            
            for(int i = 0; i < n; i++)
            {
                min = Math.Min(min, originalIndexes[i]);
                int Cvalue = originalIndexes[i] - min;
                ans = Math.Max(ans, Cvalue);
            }

            return ans;
        }
    }
}
