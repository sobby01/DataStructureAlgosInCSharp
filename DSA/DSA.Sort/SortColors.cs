using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sort
{
    public class SortColors
    {
        public List<int> SortM(List<int> arr)
        {
            int[] a = arr.ToArray();

            int low = 0;
            int high = a.Length - 1;
            int mid = 0, temp = 0;

            while (mid <= high)
            {
                switch (a[mid])
                {
                    case 0:
                        {
                            temp = a[low];
                            a[low] = a[mid];
                            a[mid] = temp;
                            low++;
                            mid++;
                            break;
                        }
                    case 1:
                        mid++;
                        break;
                    case 2:
                        {
                            temp = a[mid];
                            a[mid] = a[high];
                            a[high] = temp;
                            high--;
                            break;
                        }
                }
            }

            return a.ToList();
        }


        public int[] Sort(List<int> A)
        {
            int[] arr = A.ToArray();

            int size = arr.Length;
            int temp = -1;
            int currentIndexer = 0;
            for (int indexer = 1; indexer < size; indexer++)
            {
                currentIndexer = indexer;
                for (int leftSubset = indexer - 1; leftSubset >= 0; leftSubset--)
                {
                    if (arr[currentIndexer] < arr[leftSubset])
                    {
                        temp = arr[leftSubset];
                        arr[leftSubset] = arr[currentIndexer];
                        arr[currentIndexer] = temp;
                        currentIndexer--;
                    }


                }
            }

            return arr;
        }

        public List<int> SortUsingMergeSort(List<int> A)
        {
            int[] arr = A.ToArray();

            return MergeSortImpl(arr, 0, arr.Length);
        }

        private List<int> MergeSortImpl(int[] arr, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSortImpl(arr, left, mid);
                MergeSortImpl(arr, mid + 1, right);
                return Merge(arr, left, mid + 1, right);
            }

            return null;
        }

        private List<int> Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] l1 = new int[n1];
            int[] r1 = new int[n2];
            int i, j, k;
            for (i = 0; i < n1; i++)
            {
                l1[i] = arr[left + i];
            }

            for (j = 0; j < n2; j++)
            {
                r1[j] = arr[mid + j + 1];
            }

            i = 0; j = 0; k = left;

            while (i < n1 && j < n2)
            {
                if (l1[i] <= r1[j])
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

            while (i < n1)
            {
                arr[k++] = l1[i++];
            }

            while (j < n2)
            {
                arr[k++] = r1[j++];
            }

            return arr.ToList();
        }



        public List<int> sortColors(List<int> A)
        {
            int[] arr = A.ToArray();


            for (int i = 0; i < arr.Length; i++)
            {

                int minId = i;
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[j] < arr[minId])
                    {
                        minId = j;
                        int temp = arr[minId];
                        arr[minId] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            return arr.ToList();
        }
    }
}
