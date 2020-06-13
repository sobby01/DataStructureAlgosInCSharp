using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Maths
{
    public class CommonPrimeDivisor
    {
        private static long max_value = 214748;
        bool[] primeArray = new bool[max_value];
        public void FindCommonPrimeDivisor(long a, long b)
        {
            //First prepare the array of Prime
            //Find GCD and then loop from 2 to GCD
            // if the same number is prime in the first array
            // and it is also a divisor then compare with the minimum and publish the answer.
            MakeSieve();
            long min = Int64.MaxValue;

            long n = calculateGCD(a, b);
            
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && CheckIfPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        public bool CheckIfPrime(long number)
        {
            bool prime = true;
            if (number <= 1)
                prime = false;
            else if (number == 2)
                prime = true;
            else if (number % 2 == 0)
                prime = false;
            

            for (long i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }


            return prime;
        }

        public void FindSmallestCommonPrimeDivisor(long a, long b)
        {
            //First prepare the array of Prime
            //Find GCD and then loop from 2 to GCD
            // if the same number is prime in the first array
            // and it is also a divisor then compare with the minimum and publish the answer.
            //MakeSieve();
            long min = Int64.MaxValue;

            long n = calculateGCD(a, b);

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0 && primeArray[i])
                {
                    if (min > i)
                    {
                        min = i;
                    }
                }
            }

            Console.WriteLine(min);
        }


        long calculateGCD(long a, long b)
        {
            if (a == 0)
                return b;
            return calculateGCD(b % a, a);
        }

        public void MakeSieve()
        {
            for (int i = 0; i < max_value; i++)
            {
                primeArray[i] = true;
            }

            for (int i = 2; i < max_value; i++)
            {
                if (primeArray[i] == true)
                {
                    for (int k = i * i; k < max_value; k++)
                    {
                        primeArray[k] = false;
                    }
                }
            }

        }

    }
}
