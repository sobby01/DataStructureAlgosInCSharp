using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class Add1ToNumber
    {
        public List<int> plusOne(List<int> A)
        {

           
            int n = A.Count;           

            for (int i = n - 1; i >= 0; --i)
            {
                if (A[i] == 9)
                {
                    A[i] = 0;
                }
                else
                {
                    A[i] = A[i] + 1;
                    int j = 0;
                    while(A[j] == 0)
                    {
                        A.RemoveAt(j);
                    }
                    return A;
                }
            }

            A = new List<int>();
            A.Add(1);

            for (int i = 0; i < n; i++)
            {
                A.Add(0);
            }

            return A;



        }
    }
}
