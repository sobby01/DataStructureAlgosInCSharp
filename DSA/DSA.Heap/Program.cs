using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSA.Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter =CountDigitsClass.countDigits(99999);
        }
    }

    public class CountDigitsClass
    {
        public static int countDigits(int n)
        {
            // add your code here
            if (n % 10 == n || n == 0)
                return 1;

            int count_dig = 0;
            count_dig++;
            n = n / 10;

            return count_dig + countDigits(n);
        }
    }
}
