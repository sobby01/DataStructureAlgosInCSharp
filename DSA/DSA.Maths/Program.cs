using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            IsPrime ip = new IsPrime();
            Stopwatch st = new Stopwatch();
            st.Start();
            
            bool value = ip.EfficientCheckPrime(1073676287);
            st.Stop();
            Console.WriteLine(st.ElapsedMilliseconds);
            //1073676287
            Console.WriteLine(value);

            st.Reset();
            st.Start();
            value = ip.EfficientCheckPrime(9999999929);
            st.Stop();
            Console.WriteLine(st.ElapsedMilliseconds);
            //1073676287
            Console.WriteLine(value);

            
            //st.Start();
            //Console.WriteLine("New Number");
            //bool value2 = ip.CheckIfPrime(1073676287);
            //st.Stop();
            //Console.WriteLine(st.ElapsedMilliseconds);
            //Console.WriteLine(value2);
            return;

            GCD mm = new GCD();
            int result = mm.AllCommonDivisors(12, 16);
            Console.WriteLine(result);
            Console.ReadKey();
            return;

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

           
        }
    }
}
