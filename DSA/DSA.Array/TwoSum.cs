using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
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
                    indexes.Add(indexer);
                    indexes.Add((int)hashTable[remainingTarget]);
                    break;
                }
                if (!hashTable.ContainsKey(nums[indexer]))
                    hashTable.Add(nums[indexer], indexer);
            }

            return indexes.ToArray();
        }
    }
}
