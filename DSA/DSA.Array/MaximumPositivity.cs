using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class MaximumPositivity
    {
        public List<int> solve1(List<int> A)
        {

        }


        public List<int> solve(List<int> A)
        {
            int lastIndex = -1;
            int startValue = A[0]; int lastMaxCount = 0; int startIndexer = 0; int currentCounter = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] < 0)
                {
                    lastIndex = i;

                    if (lastIndex == -1)
                    {
                        startValue = A[0];
                        lastMaxCount = currentCounter;
                        startIndexer = 0;
                    }
                    else if (lastMaxCount < currentCounter)
                    {
                        lastMaxCount = currentCounter;
                        startValue = A[lastIndex + 1];
                        startIndexer = lastIndex + 1;
                    }
                    else if (lastMaxCount == currentCounter)
                    {
                        if (startValue > A[lastIndex + 1])
                        {
                            startValue = A[lastIndex + 1];
                            startIndexer = lastIndex + 1;
                        }
                    }
                    currentCounter = 0;
                    lastIndex++;
                }

                currentCounter++;
            }

            List<int> rList = new List<int>();
            while (startIndexer < A.Count && A[startIndexer] >= 0)
            {

                rList.Add(A[startIndexer]);
                startIndexer++;
            }

            return rList;

        }
    }
}
