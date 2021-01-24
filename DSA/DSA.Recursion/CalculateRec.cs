using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class CalculateRec
    {
        int bar(int x, int y)
        {
            if (y == 0) return 0;
            return (x + bar(x, y - 1));
        }

        public int foo(int x, int y)
        {
            if (y == 0) return 1;
            return bar(x, foo(x, y - 1));
        }

        
        public int SumOfDigits(int n)
        {
            if (n <= 0)
                return 0;
            int sum = 0;
            sum += SumOfDigits(n / 10) + n % 10;

            return sum;
        }

        /// <summary>
        /// It will never work because
        /// we are changing the value before recursion, 
        /// we should do the changes after the recursion.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int SumOfDigits1(int n)
        {
            if (n <= 0)
                return 0;
            int sum = n % 10;
            sum += SumOfDigits1(n / 10);

            return sum;
        }
    }
}
