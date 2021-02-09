using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class ToUpper
    {
        public List<char> to_upper(List<char> A)
        {
            List<char> li = new List<char>();

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] - 'A' >= 0 && A[i] - 'A' <= 26)
                {
                    li.Add(A[i]);
                }
                else if (A[i] - 'a' >= 0 && A[i] - 'a' <= 26)
                {

                    int n = A[i] - 'a';

                    li.Add((char)('A' + n));
                }
                else
                {
                    li.Add(A[i]);
                }
            }

            return li;

        }
    }
}
