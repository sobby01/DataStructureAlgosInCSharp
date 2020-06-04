using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class StringMatcher
    {
        public void NaiveStringMatcher(string text, string pattern)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < text.Length; i++)
            {
                for (j = 0; j < pattern.Length; j++)
                {
                    if (text[i + j] != pattern[j])
                        break;
                }

                if (j == pattern.Length)
                {
                    Console.Write("Match found at index {0}", i);
                    break;
                }
            }
        }
    }
}
