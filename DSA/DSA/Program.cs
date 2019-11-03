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
            //int[] unSortedArray = new[] {3, 5, 1, 4, 7, 2, 8, 9, 10,3};
            int[] unSortedArray = new[] {23, 29, 15, 19,31,7,9,5,2 };
            Console.WriteLine("unsorted Array");
            unSortedArray.ToList().ForEach(x => Console.Write(x.ToString() + " "));
            Console.WriteLine("\n Press number for following: \n");
            Console.WriteLine("Press 1 for Selection Sort \n");
            Console.WriteLine("Press 2 for Bubble Sort \n");
            Console.WriteLine("Press 3 for Merge Sort \n");
            Console.WriteLine("Press 4 for Quick Sort \n");
            Console.WriteLine("Press 5 for Insertion Sort\n");
            Console.WriteLine("Press 6 for Bucket Sort\n");
            Console.WriteLine("Press 7 for Shell Sort\n");

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
                    sort = new BubbleSort();
                    sort.Sort(unSortedArray);
                    break;
                case "5":
                    sort = new InsertionSort();
                    sort.Sort(unSortedArray);
                    break;
                case "7":
                    sort = new ShellSort();
                    sort.Sort(unSortedArray);
                    break;
            }

            unSortedArray.ToList().ForEach( x=> Console.Write(x.ToString()+ " "));
            Console.ReadKey();
        }
    }
}
