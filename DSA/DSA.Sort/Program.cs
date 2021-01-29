using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort mSort = new MergeSort();
            mSort.Sort_Detail(new int[] {5,2,3,1});
            return;

            SortColors sc = new SortColors();
            var items = sc.SortM(new List<int> { 2, 0, 0, 1, 0, 0, 2, 2, 1, 1, 0, 0, 1, 0, 2,2,1});
            return;

            LargestNumber largestNumber = new LargestNumber();
            largestNumber.largeNumber(new List<int> { 8, 3, 30, 34, 5, 9 });
            return;

            HeapSort hSort = new HeapSort();
            int[] mykeys = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("\nOriginal Array Elements :");
            hSort.printArray(mykeys);

            hSort.Sort(mykeys);

            Console.WriteLine("\n\nSorted Array Elements :");
            hSort.printArray(mykeys);
            Console.WriteLine("\n");
        }
    }
}
