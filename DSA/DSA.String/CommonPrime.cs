using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class CommonPrime
    {
        public void GetPrime()
        {
            var inputs = Console.ReadLine();

            string[] splittedNumbers = inputs.Split(' ');

            Int64 minNumber = Int64.MaxValue;
            bool isPrime = true;
            for (int i = 0; i < splittedNumbers.Length; i++)
            {
                if (minNumber > Convert.ToInt64(splittedNumbers[i]))
                {
                    minNumber = Convert.ToInt64(splittedNumbers[i]);
                }
            }

            for (int i = 0; i < splittedNumbers.Length; i++)
            {
                if (Convert.ToInt64(splittedNumbers[i]) % minNumber != 0)
                {
                    isPrime = false;
                    
                    break;
                }
            }

            if(isPrime)
                Console.WriteLine(minNumber);
            else
            {
                Console.WriteLine(-1);
            }

        }
    }
}
