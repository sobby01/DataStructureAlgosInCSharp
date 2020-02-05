using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class Median_TwoSortedArray
    {
        public double FindMedianSortedArrays_BruteForce(int[] nums1, int[] nums2)
        {
            int[] mergedArray = new int[nums1.Length + nums2.Length];

            nums1.CopyTo(mergedArray, 0);

            nums2.CopyTo(mergedArray, nums1.Length);

            System.Array.Sort(mergedArray);

            int totalLength = mergedArray.Length;

            if (totalLength % 2 != 0)
            {
                //even

                return mergedArray[totalLength / 2];
            }
            else
            {
                int indexer = totalLength / 2;

                return (double)(mergedArray[indexer-1] + mergedArray[indexer]) / 2;

                //odd
            }
        }

        public double FindMedianSortedArraysOfTwoDifferentLength(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                //First one should be shorter
                FindMedianSortedArraysOfTwoDifferentLength(nums2, nums1);
            }

            int x = nums1.Length;
            int y = nums2.Length;

            int low = 0;
            int high = x;

            while (low <= high)
            {
                int partitionX = (low + high) / 2;
                int partitionY = (x + y + 1) / 2 - partitionX;

                int maxLeftX = partitionX == 0 ? Int32.MinValue : nums1[partitionX-1];
                int minRightX = partitionX == 0 ? Int32.MaxValue : nums1[partitionX];

                int maxLeftY = partitionY == 0 ? Int32.MinValue : nums2[partitionY - 1];
                int minRighty = partitionY == 0 ? Int32.MaxValue : nums2[partitionY];

                //We have four partition array
                //left X, Right X and Left Y and Right Y
                //Left Y to Right X and left X to Right Y
                if (maxLeftX <= minRighty && maxLeftY <= minRightX)
                {
                    if ((x + y) % 2 == 0)
                    {
                        return ((double) Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRighty)) / 2;
                    }
                    else
                    {
                        return (double) Math.Max(maxLeftX, maxLeftY);
                    }
                }
                else if (maxLeftX > minRighty)
                {
                    high = partitionX - 1;
                }
                else
                {
                    low = partitionX + 1;
                }
            }

            throw new Exception();
        }
    }
}
