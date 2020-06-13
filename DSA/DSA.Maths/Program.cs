using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace DSA.Maths
{
    public class Program
    {
        static void Main(string[] args)
        {


            CommonPrimeDivisor pd = new CommonPrimeDivisor();
            var inputs = Console.ReadLine();
            string[] splittedNumbers = inputs.Split(' ');
            long a = Convert.ToInt64(splittedNumbers[0]);
            long b= Convert.ToInt64(splittedNumbers[1]);
            pd.FindCommonPrimeDivisor(a, b);

            IsPrime pp = new IsPrime();
            bool prime = pp.CheckIfPrime(307);

            Console.WriteLine(prime);
            Console.ReadKey();

            bool prime1 = pp.CheckIfPrime(4);

            Console.WriteLine(prime1);
            Console.ReadKey();

            bool prime2 = pp.CheckIfPrime(11);

            Console.WriteLine(prime2);
            Console.ReadKey();

            GCD mm = new GCD();
            int result = mm.AllCommonDivisors(12, 24);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
