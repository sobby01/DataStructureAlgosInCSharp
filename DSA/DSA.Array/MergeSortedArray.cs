using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    //Merge Sorted Array
    /*
     * Input:
     * nums1 = [1,2,3,0,0,0], m = 3
     * nums2 = [2,5,6],       n = 3
     * Output: [1,2,2,3,5,6]
     */
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //create a copy of this array : nums1
            int[] nums1_copy = new int[m];
            System.Array.Copy(nums1, nums1_copy, m);

            int p1 = 0;
            int p2 = 0;
            int finalIndexer = 0;

            while (p1 < m && p2 < n)
            {
                if (nums1_copy[p1] < nums2[p2])
                {
                    nums1[finalIndexer] = nums1_copy[p1];
                    finalIndexer++;
                    p1++;
                }
                else
                {
                    nums1[finalIndexer] = nums2[p2];
                    finalIndexer++;
                    p2++;
                }
            }

            while (p1 < m)
            {
                nums1[finalIndexer++] = nums1_copy[p1];
                p1++;
            }

            while (p2 < n)
            {
                nums1[finalIndexer++] = nums2[p2];
                p2++;
            }
        }
    }
}
