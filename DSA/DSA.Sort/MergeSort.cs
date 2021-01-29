using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;


namespace DSA.Sort
{
    public class MergeSort : ISorting
    {
        public void Sort(int[] arr)
        {
            MergeSortImpl(arr, 0, arr.Length - 1);
        }

        public int[] Sort_Detail(int[] arr)
        {
            if(arr.Length <= 1)
            {
                return arr;
            }

            int pivot = arr.Length / 2;
            int[] d1 = new int[pivot];

            Array.Copy(arr, d1, pivot);
            int[] left_list = Sort_Detail(d1);
            int[] d2 = new int[arr.Length - pivot];
            Array.Copy(arr, pivot, d2, 0, arr.Length - pivot);
            int[] rightList = Sort_Detail(d2);
            return merge(left_list, rightList);
        }

        public int[] merge(int[] left_list, int[] right_list)
        {
            int[] ret = new int[left_list.Length + right_list.Length];
            int left_cursor = 0, right_cursor = 0, ret_cursor = 0;

            while (left_cursor < left_list.Length &&
                   right_cursor < right_list.Length)
            {
                if (left_list[left_cursor] < right_list[right_cursor])
                {
                    ret[ret_cursor++] = left_list[left_cursor++];
                }
                else
                {
                    ret[ret_cursor++] = right_list[right_cursor++];
                }
            }
            // append what is remain the above lists
            while (left_cursor < left_list.Length)
            {
                ret[ret_cursor++] = left_list[left_cursor++];
            }
            while (right_cursor < right_list.Length)
            {
                ret[ret_cursor++] = right_list[right_cursor++];
            }
            return ret;
        }


        public void MergeSortImpl(int[] arr, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSortImpl(arr, left, mid);
                MergeSortImpl(arr, mid + 1, right);
                Merge(arr, left, mid + 1, right);
            }
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] l1 = new int[n1];
            int[] r1 = new int[n2];
            int i, j, k;
            for(i = 0; i < n1; i++)
            {
                l1[i] = arr[left + i];
            }

            for(j = 0; j < n2; j++)
            {
                r1[j] = arr[mid + j + 1];
            }

             i = 0;  j = 0; k = left;

            while(i < n1 && j < n2)
            {
                if(l1[i] <= r1[j])
                {
                    arr[k] = l1[i];
                    i++;
                }
                else
                {
                    arr[k] = r1[j];
                    j++;
                }
                k++;
            }

            while(i < n1)
            {
                arr[k++] = l1[i++];
            }

            while(j < n2)
            {
                arr[k++] = r1[j++];
            }

        }
    }
}
