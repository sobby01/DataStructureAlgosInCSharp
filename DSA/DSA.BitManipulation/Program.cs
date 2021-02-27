using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BitManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            InvertBitsOfNumber ibon = new InvertBitsOfNumber();
            int num = ibon.invertBits(10);

            LengthOfNumber lon = new LengthOfNumber();
            int length = lon.GetLength(1023);

            CheckEvenOdd cke = new CheckEvenOdd();
            cke.Check(6);
            return;

            CountTotalSetBits sb = new CountTotalSetBits();
            int count = sb.CountBitsHalfN(1);
            return;

            sb.CountBits(1);
            return;

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
