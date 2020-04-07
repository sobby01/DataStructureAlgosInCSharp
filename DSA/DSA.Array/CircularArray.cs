using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class CircularArray
    {
        public void PrintCircularArray(int[] arr, int startPos)
        {
            for (int i = startPos; i < startPos + arr.Length; i++)
            {
                //this will print from the starting position and 
                int number = arr[i % arr.Length];
                Console.WriteLine(number + " ");
            }
        }

        public void BuildArray()
        {
            int [] arr = new int[]{ 1,3,4,5,6,2,8,0};
            PrintCircularArray(arr, 3);
        }
    }
}
