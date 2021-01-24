using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            NobleElements ne = new NobleElements();
            ne.GetElement(new List<int> { 6, 7, 5 });
            return;

            //LargestNumber largestNumber = new LargestNumber();
            //largestNumber.largeNumber(new List<int> {8, 3, 30, 34, 5,9 });
            //return;

            //HeapSort hSort = new HeapSort();
            //int[] mykeys = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            //Console.WriteLine("\nOriginal Array Elements :");
            //hSort.printArray(mykeys);

            //hSort.Sort(mykeys);

            //Console.WriteLine("\n\nSorted Array Elements :");
            //hSort.printArray(mykeys);
            //Console.WriteLine("\n");

        }
    }
}
