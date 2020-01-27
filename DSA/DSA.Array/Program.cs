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
            int[] list = new[] { -3,4,3,90};


            TwoSumChallenge sumChallenge = new TwoSumChallenge();
            sumChallenge.TwoSum(list, 0);

            list = new[] {42,39};
            Decompress_RunLength_EncodedList decompressedlist = new Decompress_RunLength_EncodedList();
            decompressedlist.DecompressRLElist(list);
        }
    }
}
