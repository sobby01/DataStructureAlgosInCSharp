using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            RainTrapWater trapWater = new RainTrapWater();
            trapWater.TrapWater(new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1});
            return;
            Combination comb = new Combination();
            comb.CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);

            int[] num1= new int[]
            {
                1,3,8,9,15
            };

            int[] num2 = new int[]
            {
                7,11,18,19,21,25
            };


            int[] num11 = new int[]
            {
                2
            };

            int[] num21 = new int[]
            {
                
            };

            Median_TwoSortedArray mergeArray = new Median_TwoSortedArray();
            var output = mergeArray.FindMedianSortedArraysOfTwoDifferentLength(num11, num21);

            Console.ReadKey();
            int[] list = new[] { -3,4,3,90};


            TwoSumChallenge sumChallenge = new TwoSumChallenge();
            sumChallenge.TwoSum(list, 0);

            list = new[] {42,39};
            Decompress_RunLength_EncodedList decompressedlist = new Decompress_RunLength_EncodedList();
            decompressedlist.DecompressRLElist(list);
        }
    }
}
