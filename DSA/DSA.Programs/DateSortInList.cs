using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Programs
{
    public class DateSortInList : IComparer<string>
    {
        static Dictionary<string, int> monthMap = new Dictionary<string, int>
        {
            {"Jan", 1},
            {"Feb", 2},
            {"Mar", 3},
            {"Apr", 4},
            {"May", 5},
            {"Jun", 6},
            {"Jul", 7},
            {"Aug", 8},
            {"Sep", 9},
            {"Oct", 10},
            {"Nov", 11},
            {"Dec", 12}
        };

        public int Compare(string x, string y)
        {
            var d1 = x.Split(" ".ToCharArray());
            var d2 = y.Split(" ".ToCharArray());

            if (d1[2].Equals(d2[2]))
            {
                int m1 = monthMap[d1[1]];
                int m2 = monthMap[d2[1]];

                if (m1 == m2)
                {
                    return d1[0].CompareTo(d2[0]);
                }

                return m1 - m2;
            }

            int val=  d1[2].CompareTo(d2[2]);
            return val;
        }


        //public static IEnumerable<DateTime> DateCompare(List<string> dates)
        //{
        //    IEnumerable<DateTime> dtes =
        //        dates.Select(
        //                str => DateTime.ParseExact(str, "dd-MM-yyyy", CultureInfo.InvariantCulture)
        //            ).
        //            OrderBy(dt => dt);

        //    dtes =
        //        dates.Select(
        //                str => DateTime.ParseExact(str, "dd-MM-yyyy", CultureInfo.InvariantCulture)
        //            ).
        //            OrderBy(dt => dt);
        //}

        

       
    }
}
