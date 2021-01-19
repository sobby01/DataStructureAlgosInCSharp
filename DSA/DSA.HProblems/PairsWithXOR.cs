using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashingProblems
{
    public class PairsWithXOR
    {
        public int Solve(List<int> A, int B)
        {
           int count = 0;
           List<int> map = new List<int>();

            for(int j =0; j< A.Count; j++)
            {
                int required = A[j] ^ B;
                if (map.Contains(required))
                {
                    count++;
                }
                else
                {
                    map.Add(A[j]);
                }
            }

            return count;
        }
    }
}
