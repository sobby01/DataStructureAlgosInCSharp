using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    /*
        Given an array of positive numbers, find the maximum sum of a subsequence with the constraint that
        no 2 numbers in the sequence should be adjacent in the array. So 3 2 7 10 should return 13 (sum of 3 and 10) 
        or 3 2 5 10 7 should return 15 (sum of 3, 5 and 7).Answer the question in most efficient way. 
    */
    public class MaxSumWithNoTwoAdjElements
    {
        /* Function to return max sum such 
   that no two elements are adjacent */
        public int FindMaxSum(int[] arr, int n)
        {
            int exclusive = arr[0];
            int inclusive = 0;

            for(int i = 2; i < n; i++)
            {
                exclusive = Math.Max(exclusive, inclusive);

                inclusive = exclusive + arr[i];
            }

            return Math.Max(exclusive, inclusive);
        }
    }
}
