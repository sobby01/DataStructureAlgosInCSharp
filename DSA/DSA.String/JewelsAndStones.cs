using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            int totalJewels = 0;

            Dictionary<char, int> numJewels = new Dictionary<char, int>();

            char[] charArray = J.ToCharArray();

            for (int indexer = 0; indexer < charArray.Length; indexer++)
            {
                if (numJewels.ContainsKey(J[indexer]))
                {
                    numJewels[J[indexer]] = numJewels[J[indexer]] + 1;
                }
                else
                {
                    numJewels.Add(J[indexer], 1);
                }
            }

            char[] stoneArray = S.ToCharArray();

            for (int indexer = 0; indexer < stoneArray.Length; indexer++)
            {
                if (numJewels.ContainsKey(stoneArray[indexer]))
                {
                    totalJewels += 1;
                }
            }
            return totalJewels;
        }
    }
}
