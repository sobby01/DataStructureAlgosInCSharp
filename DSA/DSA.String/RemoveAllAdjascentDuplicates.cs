using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    /*
     *  Input: "abbaca"
        Output: "ca"
        Explanation: 
        For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, 
        and this is the only possible move.  
        The result of this move is that the string is "aaca", of which only "aa" 
        is possible, so the final string is "ca".
     *
     */
    public class RemoveAllAdjascentDuplicates
    {
        public string RemoveDuplicates(string S)
        {
            StringBuilder sb = new StringBuilder(S);
            int indexer = 0;

            while (indexer < sb.Length -1)
            {
                if (sb[indexer] == sb[indexer + 1])
                {
                    sb.Remove(indexer, 2);
                    indexer = 0;
                }
                else
                {
                    indexer++;
                }
            }

            return sb.ToString();
        }
    }
}
