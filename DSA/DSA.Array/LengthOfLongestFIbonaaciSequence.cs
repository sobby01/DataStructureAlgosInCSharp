using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class LengthOfLongestFIbonaaciSequence
    {
        /*
         *  Input: [1,2,3,4,5,6,7,8]
            Output: 5
            Explanation:
            The longest subsequence that is fibonacci-like: [1,2,3,5,8].
         */
        public int longestString(int[] arr)
        {
            int totalLength = 0;
            List<int> fibSequence = new List<int>();
            for (int indexer = 2; indexer < arr.Length; indexer++)
            {
                if (arr[indexer] == arr[indexer - 1] + arr[indexer - 2])
                {
                    totalLength += 1;
                    if (!fibSequence.Contains(arr[indexer - 2]))
                    {
                        totalLength += 1;
                        fibSequence.Add(arr[indexer - 2]);
                    }

                    if (!fibSequence.Contains(arr[indexer - 1]))
                    {
                        totalLength += 1;
                        fibSequence.Add(arr[indexer - 1]);
                    }
                        
                    fibSequence.Add(arr[indexer]);
                }
                else if(fibSequence.Count >=2 && arr[indexer] == fibSequence[fibSequence.Count-1] + 
                        fibSequence[fibSequence.Count - 2])
                {
                    totalLength += 1;
                    fibSequence.Add(arr[indexer]);
                }
            }

            return totalLength;
        }
    }
}
