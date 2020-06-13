using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class CyclicPermutations
    {
        public long CountDigits(long n)
        {
            long count = 0;

            while (n > 0)
            {
                n = n / 10;
                count++;
            }

            return count;
        }

        public void FindCyclicPermutations_string()
        {
            int noOfTestCases = Convert.ToInt32(Console.ReadLine());

            while (noOfTestCases > 0)
            {
                string numberA = Console.ReadLine();
                string numberB = Console.ReadLine();



                noOfTestCases--;
            }
        }

        public void FindCyclicPermutations()
        {
            int noOfTestCases = Convert.ToInt32(Console.ReadLine());

            while (noOfTestCases > 0)
            {
                long numberA = Convert.ToInt64(Console.ReadLine());
                long numberB = Convert.ToInt64(Console.ReadLine());

                //Generate the cyclic permutations of numberB
                long totalCount = 0;

                long value = numberA ^ numberB;

                if (value == 0)
                    totalCount += 1;

                long numberOFDigits = CountDigits(numberB);
                long number = numberB;
                for (long i = 0; i < numberOFDigits - 1; i++)
                {
                    long remainder = numberB % 10;
                    long div = numberB / 10;
                    number = (long)(Math.Pow(10, numberOFDigits - 1) * remainder) + div;

                    value = numberA ^ number;

                    if (value == 0)
                        totalCount += 1;
                }

                Console.WriteLine(totalCount);

                noOfTestCases--;
            }
        }
    }
}
