using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    /// <summary>
    /// Array Intersection
    /// </summary>
    public class ArrayIntersection
    {
        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            IList<int> objList =new List<int>();
            HashSet<int> set1 = new HashSet<int>(arr1);
            HashSet<int> set2 = new HashSet<int>(arr2);
            HashSet<int> set3 = new HashSet<int>(arr3);

            foreach (int number in set1)
            {
                if (set2.Contains(number) && set3.Contains(number))
                {
                    objList.Add(number);
                }
            }

            return objList;
        }
    }
}
