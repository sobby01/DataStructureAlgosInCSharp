using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class Decompress_RunLength_EncodedList
    {
        public int[] DecompressRLElist(int[] nums)
        {
            
            int currentIndexer = 0;
            int size = 0;
            for (int sizeIndexer = 0; sizeIndexer < nums.Length; sizeIndexer += 2)
            {
                size += nums[sizeIndexer];
            }
            int[] decompressedlist = new int[size];
            for (int indexer = 0; indexer < nums.Length; indexer += 2)
            {
                int freq = nums[indexer];
                while (freq > 0)
                {
                    decompressedlist[currentIndexer] = nums[indexer + 1];

                    currentIndexer++;
                    freq--;
                }
            }

            return decompressedlist;

        }

        public int[] DecompressRLElistUsinglist(int[] nums)
        {
            int currentIndexer = 0;
            
            List<int> decompressedlist = new List<int>();
            int indexer;
            for (indexer =0; indexer < nums.Length; indexer += 2)
            {
                int freq = nums[indexer];
                while (freq > 0)
                {
                    decompressedlist.Add(nums[indexer + 1]);
                    freq--;
                }
            }

            return decompressedlist.ToArray();

        }
    }


}
