using DSA.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] unSortedArray = new[] {3, 5, 1, 4, 7, 2, 8, 9, 10};
            Console.WriteLine("unsorted Array");
            unSortedArray.ToList().ForEach(x => Console.Write(x.ToString() + " "));
            Console.WriteLine("\n Press number for following: \n");
            Console.WriteLine("Press 1 for Selection Sort \n");
            Console.WriteLine("Press 2 for Bubble Sort \n");
            Console.WriteLine("Press 3 for Merge Sort \n");
            Console.WriteLine("Press 4 for Quick Sort \n");
            Console.WriteLine("Press 5 for Insertion Sort\n");
            Console.WriteLine("Press 6 for Bucket Sort\n");

            string number = Console.ReadLine();
            int result;
            ISorting sort = new SelectionSort();
            if (!int.TryParse(number, out result) && (result > 0 && result <= 6))
            {
                Console.WriteLine("Provide the input from 1 to 6");
            }
            switch (number)
            {
                case "1":
                    sort = new SelectionSort();
                    sort.Sort(unSortedArray);
                    break;
                case "2":
                    sort = new SelectionSort();
                    sort.Sort(unSortedArray);
                    break;
            }

            unSortedArray.ToList().ForEach( x=> Console.Write(x.ToString()+ " "));
            Console.ReadKey();
        }
    }
}
