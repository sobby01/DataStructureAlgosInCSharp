using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class SumOfAdjacentNumbers
    {
        public int Calculate( int[] arr)
        {
            int oddNumber = 0;
            int evenNumber = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    evenNumber++;
                }
                else
                {
                    oddNumber++;
                }
            }

            return Math.Min(evenNumber, oddNumber);
        }
    }
}
