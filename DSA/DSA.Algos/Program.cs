using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            KadaneAlgo ka = new KadaneAlgo();
            int sum = ka.MaxGlobal(new int[] { -2, 3, 2, -1 });
            Console.WriteLine(sum);
            return;
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
