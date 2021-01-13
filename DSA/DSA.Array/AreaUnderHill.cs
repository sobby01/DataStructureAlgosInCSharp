using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class AreaUnderHill
    {
        public string solve(List<int> A)
        {
            long area = 0;

            for (int i = 0; i < A.Count; i++)
            {
                area += A[i];
            }

            return area.ToString();
        }
    }
}
