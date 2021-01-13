using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class FindMissingElement
    {
        public int Solve(List<int> A)
        {
            int xorElement = 0;
            int count = A.Count;
            int maxElement = 0;
            for (int i = 0; i < count; i++)
            {
                maxElement = Math.Max(maxElement, A[i]);
            }

            for (int i = 1; i <= maxElement; i++)
            {
                A.Add(i);
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                xorElement = xorElement ^ A[i];
            }

            if (xorElement == 0)
                return 1;
            else
                return 0;
        }
    }
}
