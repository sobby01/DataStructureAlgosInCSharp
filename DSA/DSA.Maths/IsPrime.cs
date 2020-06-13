using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Maths
{
    public class IsPrime
    {
        public bool CheckIfPrime(int number)
        {
            bool prime = true;

            if (number % 2 == 0)
                prime = false;
            if (number <= 1)
                prime = false;

            for (int i = 3; i <= Math.Sqrt(number); i+=2)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }


            return prime;
        }


        public void MakeSieve(int max)
        {
            bool[] isPrime = new bool[max+1];

            for (int i = 0; i < max; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= max; p++)
            {
                if (isPrime[p] == true)
                {
                    for (int i = p * p; i <= max; i++)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            for (int i = 2; i <= max; i++)
            {
                if(isPrime[i])
                    Console.WriteLine("{0} ",i);
            }
        }
    }
}
