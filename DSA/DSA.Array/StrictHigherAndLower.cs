using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class StrictHigherAndLower
    {
        public int Solve(List<int> A)
        {
            if (A.Count < 3)
                return 0;
            int[] aa = A.ToArray();
            Array.Sort(aa);

            int index = 1;
            int skipStartIndexes = 1;
            int skipEndIndexes = 1;
            while (true && index < A.Count)
            {
                if(aa[index] == aa[index-1])
                {
                    skipStartIndexes++;
                    index++;
                }
                else
                {
                    break;
                }
            }
            index = aa.Length - 2;

            bool calculateSecondIndexer = false;

            while (true && index >= skipStartIndexes)
            {
                calculateSecondIndexer = true;
                if (aa[index] == aa[index+1])
                {
                    skipEndIndexes++;
                    index--;
                }
                else
                {
                    break;
                }
            }

            if (calculateSecondIndexer)
                return A.Count - skipEndIndexes - skipStartIndexes;
            else
                return A.Count - skipStartIndexes;
        }
    }
}
