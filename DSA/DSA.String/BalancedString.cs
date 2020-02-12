using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    //Leetcode : 1234. Replace the Substring for Balanced String
    public class BalancedString
    {
        public int balancedString(string s)
        {
            int balanced = 0;
            int eachCharavail = 0;
            Dictionary<char, int> objHashTable = new Dictionary<char, int>();

            for (int indexer = 0; indexer < s.Length; indexer++)
            {
                if (!objHashTable.ContainsKey(s[indexer]))
                {
                    objHashTable.Add(s[indexer], 1);
                }
                else
                {
                    int value = objHashTable[s[indexer]];
                    objHashTable[s[indexer]] = value + 1;
                }
            }

            foreach(var coll in objHashTable.Values)
            {
                if (coll - (s.Length / 4) > 0)
                {
                    balanced += coll - (s.Length / 4);
                }
                
                eachCharavail = eachCharavail + 1;
            }


            return balanced;
        }
    }
}
