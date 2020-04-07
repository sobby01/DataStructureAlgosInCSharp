using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
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
