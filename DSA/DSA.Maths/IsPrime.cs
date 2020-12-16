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
        //1,2,3,5,7,11
        //2: 2,4,6,8,10,12,16,18,20,22,24
        //3: 3,6,9,12,15,18,21
        //5, 7, 11,13, 17,19, 23, 25

        //77 => 8.6
        public bool EfficientCheckPrime(long number)
        {
            if (number <= 3)
                return true;
            else if (number % 2 == 0 || number % 3 == 0)
                return false;
            for (int i = 5; i*i < number; i = i + 6)
            //for (int i = 5; i < Math.Sqrt(number); i = i + 6)
            {
                if (number % i == 0 || number % i + 2 == 0)
                    return false;
            }

            return true;
        }

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
