using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sort
{
    public class MergeArrays
    {
        public List<int> solve(List<int> A, List<int> B)
        {
            List<int> mergeArray = new List<int>();
            int startPointerA = 0;
            int startPointerB = 0;

            while (startPointerA < A.Count && startPointerB < B.Count)
            {
                if (A[startPointerA] < B[startPointerB])
                {
                    mergeArray.Add(A[startPointerA]);
                    startPointerA++;
                }
                else if (B[startPointerB] < A[startPointerA])
                {
                    mergeArray.Add(B[startPointerB]);
                    startPointerB++;
                }
                else
                {
                    mergeArray.Add(A[startPointerA]);
                    startPointerB++;
                    startPointerA++;
                }
            }

            while (startPointerA < A.Count)
            {
                mergeArray.Add(A[startPointerA]);
                startPointerA++;
            }

            while (startPointerB < B.Count)
            {
                mergeArray.Add(B[startPointerB]);
                startPointerB++;
            }

            return mergeArray;
        }
    }
}
