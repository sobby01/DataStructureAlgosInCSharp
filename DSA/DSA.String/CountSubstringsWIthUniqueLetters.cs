using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    /*
     *  Input: S = "aaaba"
        Output: 8
        Explanation: The substrings with one distinct letter are "aaa", "aa", "a", "b".
        "aaa" occurs 1 time.
        "aa" occurs 2 times.
        "a" occurs 4 times.
        "b" occurs 1 time.
        So the answer is 1 + 2 + 4 + 1 = 8.
     */
    public class CountSubstringsWIthUniqueLetters
    {
        public int CountLetters(string S)
        {
            if (S.Length == 0 || string.IsNullOrWhiteSpace(S))
            {
                return 0;
            }

            int counter = 1;
            int prevCOunter = 1;

            for (int indexer = 0; indexer < S.Length; indexer++)
            {
                if (indexer > 0)
                {
                    if (S[indexer] == S[indexer - 1])
                    {
                        prevCOunter++;
                    }
                    else
                    {
                        prevCOunter = 1;
                    }
                }
                else
                {
                    prevCOunter++;
                }

                counter += prevCOunter;
            }

            return counter;
        }
    }
}
