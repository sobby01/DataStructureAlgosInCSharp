using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class TwoArrayIntersection
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            IList<int> objList = new List<int>();
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

            foreach (int number in set1)
            {
                if (set2.Contains(number))
                {
                    objList.Add(number);
                }
            }

            return objList.ToArray();
        }
    }
}
