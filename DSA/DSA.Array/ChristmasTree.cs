using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class ChristmasTree
    {
        public int solve(List<int> A, List<int> B)
        {
            int finalCost = Int32.MaxValue;
            for (int i = 0; i < A.Count; i++)
            {
                int leftCost = Int32.MaxValue;
                int rightCost = Int32.MaxValue;

                for (int j = 0; j < i; j++)
                {
                    if (A[j] < A[i])
                    {
                        leftCost = Math.Min(leftCost, B[j]);
                    }
                }

                for (int k = i + 1; k < A.Count; k++)
                {
                    if (A[k] > A[i])
                    {
                        rightCost = Math.Min(rightCost, B[k]);
                    }
                }

                if (leftCost != Int32.MaxValue && rightCost != Int32.MaxValue)
                    finalCost = Math.Min(finalCost, leftCost + rightCost + B[i]);
            }

            if (finalCost == Int32.MaxValue)
                return -1;

            return finalCost;
        }
    }
}
