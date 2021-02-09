using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    class Program
    {
        static void Main(string[] args)
        {
            DecodeWays dw = new DecodeWays();
            dw.recursiveWithMemo(0, "10");
            dw.Recursive_NumDecode(0, "10");
            //dw.NumDecodings("12");
            return;

            CoinChange cc = new CoinChange();
            int output = cc.GetCount(new int[] { 2, 5, 3, 6 }, 4, 10);
            Console.WriteLine(output);
            return;

            MaxSumWithNoTwoAdjElements mm = new MaxSumWithNoTwoAdjElements();
            int sum = mm.FindMaxSum(new int[] { 7, 2, 4, 9, 1 }, 5);
            Console.WriteLine(sum);
            return;

            FibonacciWithMemoization fm = new FibonacciWithMemoization();
            int fibVal = fm.CalculateFib(2);
            Console.WriteLine(fibVal);
            fibVal = fm.CalculateFib(0);
            Console.WriteLine(fibVal);

            fibVal = fm.CalculateFib(1);
            Console.WriteLine(fibVal);
            return;

            LongestPalindromeSubsequence pSeq = new LongestPalindromeSubsequence();
            pSeq.PrintLongestPalindromeSubseq("BBABCBCAB");
            //Console.WriteLine(value);
            return;
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
