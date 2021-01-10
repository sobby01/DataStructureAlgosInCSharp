using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class ELementsWithTwoGreatest
    {
        public List<int> solve(List<int> A)
        {
            List<int> val = new List<int>();

            int firstMax = int.MinValue;
            int secondMAx = -1;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > firstMax)
                {
                    secondMAx = firstMax;
                    firstMax = A[i];
                }
                else if (A[i] > secondMAx)
                {
                    secondMAx = A[i];
                }
            }

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] < secondMAx)
                {
                    val.Add(A[i]);
                }
            }

            return val;
        }
    }
}
