using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class MultiplicationOfPrevAndNext
    {
        public List<int> solve1(List<int> A)
        {
            int n = A.Count;

            if (n <= 1)
                return A;

            int prev = A[0];
            A[0] = A[0] * A[1];

            for (int i = 1; i < n - 1; i++)
            {
                int curr = A[i];
                A[i] = prev * A[i + 1];
                prev = curr;
            }
            A[n - 1] = prev * A[n - 1];

            return A;
        }
    }
}
