using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class MaxEvenAndMinOdd
    {
        public int solve(List<int> A)
        {
            int maxEven = int.MinValue;
            int minOdd = int.MaxValue;

            for(int i = 0; i < A.Count; i++)
            {
                if(A[i] %2 == 0 )
                {
                    if(A[i] > maxEven)
                        maxEven = A[i];
                }
                else
                {
                    if (A[i] < minOdd)
                        minOdd = A[i];
                }
            }

            return maxEven - minOdd;
        }
    }
}
