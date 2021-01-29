using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String.String_Matching
{
    public class KMP_Substring
    {
        private void ComputeArray(string pattern, int[]kmp)
        {
            int length = pattern.Length;
            //This will always be 0
            kmp[0] = 0;

            int i = 0;
            int j = 1;
            while(j < length)
            {
                if(pattern[i] == pattern[j])
                {
                    kmp[i] = i + 1;
                    i++;
                    j++;
                }
                else
                {
                    if( i== 0)
                    {
                        kmp[i] = 0;
                        i++;
                    }
                    else
                    {
                        i = kmp[i - 1];
                    }
                }
            }
        }

        public bool SolveKMP(string text, string pattern)
        {
            int[] kmp = new int[pattern.Length];
            int i = 0; int j = 0;
            while(i < text.Length && j < pattern.Length)
            {
                if(text[i] == pattern[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if(j != 0)
                    {
                        j = kmp[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            if(j == pattern.Length)
            {
                return true;
            }

            return false;
        }
    }
}
