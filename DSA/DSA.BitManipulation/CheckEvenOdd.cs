using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BitManipulation
{
    public class CheckEvenOdd
    {
        public void Check(int n)
        {
            if (n % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");

            if((n & 1) == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}
