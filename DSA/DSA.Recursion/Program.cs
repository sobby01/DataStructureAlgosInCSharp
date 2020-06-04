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
            Reverse revString = new Reverse();
            revString.ReverseString(new char[]{'H', 'E', 'I', 'L', 'O', 'S'});

            Console.ReadKey();
            PermutationOfString permutations = new PermutationOfString();
            permutations.PrintPermutations(new char[]{'A', 'B','C'}, new char[3], new int[]{1,1,1}, 0 );


            Factorial facto = new Factorial();
            int num = facto.FindFactorial_recursive(5);

            Console.WriteLine(num.ToString());
        }
    }
}
