using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DSA.Sorting
{
    public class MergeSort : ISorting
    {
        

        public void Sort(int[] arr)
        {
            
        }

        public void MergeSortImpl(int[] arr, int[] temp, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSortImpl(arr, temp, left, mid);
                MergeSortImpl(arr, temp, mid + 1, right);
                Merge(arr, temp, left, mid + 1, right);
            }
        }

        private void Merge(int[] arr, int[] temp, int left, int mid, int right)
        {

        }
    }
}
