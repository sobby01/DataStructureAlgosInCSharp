using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Programs
{
    public static class FizzBuzz
    {
        public static void fizzBuzz(int n)
        {
            var fizzBuzz = Enumerable.Range(0, n).Where(i => i % 3 == 0 && i % 5 == 0);

            for (int indexer = 1; indexer < n; indexer++)
            {
                if (indexer % 3 == 0 && indexer % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (indexer % 3 == 0 && indexer % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (indexer % 3 != 0 && indexer % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (indexer % 3 != 0 && indexer % 5 != 0)
                {
                    Console.WriteLine(indexer);
                }
            }
        }
    }
}
