using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Programs
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> dateCollection = new List<string>();
            dateCollection.Add("19 Mar 2000");
            dateCollection.Add("04 Jan 2000");
            dateCollection.Add("05 Mar 1987"); dateCollection.Add("22 Jul 2002");
            dateCollection.Add("19 Apr 1989");
            dateCollection.Add("30 Jun 1990");
            dateCollection.Add("06 Apr 2002");
            dateCollection.Add("20 Dec 2003");
            dateCollection.Add("10 Nov 2006");
            dateCollection.Add("22 Jul 2022");


            //IEnumerable<DateTime> dtes =
            //    dateCollection.Select(
            //            str => DateTime.ParseExact(str, "dd MMM yyyy", CultureInfo.InvariantCulture)
            //        ).
            //        OrderBy(dt => dt);

            //foreach (var date in dtes)
            //{
            //    Console.WriteLine(date.ToString("dd MMM yyyy"));
            //    /* DateTime.TryParseExact(date.ToString(), "dd MMM yyyy")*/
            //    //Console.WriteLine(date);
            //}

            DateSortInList sotrtedList = new DateSortInList();
            string[] collectionArr = dateCollection.ToArray();

            Array.Sort(collectionArr, sotrtedList);

            foreach (var date in collectionArr)
            {
                Console.WriteLine(date);
                /* DateTime.TryParseExact(date.ToString(), "dd MMM yyyy")*/
                //Console.WriteLine(date);
            }


            //Console.WriteLine(compValue);
            Console.Read();

            int[] arra = new[]
            {
                6,
                7,
                8,
                7,
                6,
                8,
                1,
                7,
                6,
                5
            };

            FindNonRepeatingElements.firstNonRepeating(arra,10);
            Console.ReadKey();
            return;
            

            WordReverse.ReverseWords("My Name is Saurabh and I am nobody.");

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            FizzBuzz.fizzBuzz(n);
        }
    }
}
