using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class ElementRemovalCost
    {
        public int solve(List<int> A)
        {
            int totalCost = 0;
            List<int> sumArray = new List<int>();
            int[] arr = A.ToArray();
            Array.Sort(arr);

            int j = 0; int cValue = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                totalCost = 0;
                cValue = arr[i];
                for (j = 0; j < sumArray.Count; j++)
                {
                    if(sumArray[j] != 0)
                    {
                        sumArray[j] += cValue;
                        totalCost += sumArray[j];
                    }
                }

                sumArray.Add(cValue);
            }

            totalCost += cValue;

            return totalCost;
        }
    }
}
