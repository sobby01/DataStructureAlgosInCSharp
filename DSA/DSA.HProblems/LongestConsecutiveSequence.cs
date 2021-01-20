using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashingProblems
{
    public class LongestConsecutiveSequence
    {
        public int longestConsecutive(List<int> A)
        {

            List<int> items = new List<int>();
            int maxLength = 0;
            for (int i = 0; i < A.Count; i++)
            {
                items.Add(A[i]);
            }
            int currentLength = 0;
            for (int i = 0; i < A.Count; i++)
            {
                currentLength = 0;

                int j = i;

                while (j < A.Count && items.Contains(A[j]))
                {
                    j++;
                    currentLength++;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }

            return maxLength;

        }
    }
}
