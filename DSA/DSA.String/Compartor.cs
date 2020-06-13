using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    using System;
    using System.Collections.Generic;

    class MyCOmparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {

            if (x == null || y == null)
            {
                return 0;
            }

            // "CompareTo()" method 
            return x.CompareTo(y);

        }
    }

    public class ComparerImpl
    {

        // Main Method 
        public static void Main1()
        {
            List<string> list1 = new List<string>();

            // list elements 
            list1.Add("A");
            list1.Add("I");
            list1.Add("G");
            list1.Add("B");
            list1.Add("E");
            list1.Add("H");
            list1.Add("F");
            list1.Add("C");
            list1.Add("J");

            Console.WriteLine("Original List");

            // Display Original List 
            Display(list1);

            // "gg" is the object 
            MyCOmparer gg = new MyCOmparer();

            Console.WriteLine("\nSort with a comparer:");

            // sort the list with a  
            // specified comparer "gg" 
            list1.Sort(StringComparer.Ordinal);

            // Display sorted List 
            Display(list1);

            Console.WriteLine("\nBinarySearch and Insert D");

            // Binary Search for "D" 
            // using List.BinarySearch(T) method 
            int index = list1.BinarySearch("D");

            if (index < 0)
            {

                // range++; 
                list1.Insert(~index, "D");

            }

            // Display the List after 
            // inserting "D" 
            Display(list1);

        }

        // Display function 
        public static void Display(List<string> list)
        {
            foreach (string g in list)
            {
                Console.WriteLine(g);
            }
        }
    }

}
