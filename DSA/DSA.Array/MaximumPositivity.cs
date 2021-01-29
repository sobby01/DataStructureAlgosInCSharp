using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class MaximumPositivity
    {
        public List<int> maxset(List<int> A)
        {
            List<int> ls = new List<int>();
            long currentSum = 0;
            int startIndex = 0; int endIndex = 0;
            long maxSum = long.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                currentSum = 0;
                int j = i;

                while (j < A.Count && A[j] >= 0)
                {
                    currentSum += A[j];
                    j++;
                }

                if (currentSum > maxSum)
                {
                    startIndex = i;
                    endIndex = j;
                    maxSum = currentSum;
                }
                i = j;
            }
            for (int k = startIndex; k < endIndex; k++)
            {
                ls.Add(A[k]);
            }

            return ls;
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
