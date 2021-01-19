using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class TwoSumChallenge
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> indexes = new List<int>();
            Hashtable hashTable = new Hashtable();

            for (int indexer = 0; indexer < nums.Length; indexer++)
            {
                int fixedValue = nums[indexer];
                int remainingTarget = target - fixedValue;

                if (hashTable.ContainsKey(remainingTarget))
                {
                    indexes.Add(indexer+1);
                    indexes.Add((int)hashTable[remainingTarget]);
                    break;
                }
                if (!hashTable.ContainsKey(nums[indexer]))
                    hashTable.Add(nums[indexer], indexer+1);
            }

            return indexes.ToArray();
        }


        public int solve(List<int> A, int B)
        {
            int count = 0;

            List<int> li = new List<int>();

            for (int i = 0; i < A.Count; i++)
            {

                int remainingValue = B - A[i];

                if (li.Contains(remainingValue))
                {
                    count++;
                }

                if (!li.Contains(A[i]))
                {
                    li.Add(A[i]);
                }
            }

            return count;
            
        }
        private bool sumsToTarget(int[] arr, int k)
        {
            Array.Sort(arr);
            int lhs = 0;
            int rhs = arr.Count() - 1;
            while (lhs < rhs)
            {
                int sum = arr[lhs] + arr[rhs];
                if (sum == k) return true;
                else if (sum < k) lhs++;
                else rhs--;
            }
            return false;
        }
    }
}
