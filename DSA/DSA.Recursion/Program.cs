using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Factorial facto = new Factorial();
            int num = facto.FindFactorial_recursive(5);

            Console.WriteLine(num.ToString());
        }
    }
}
