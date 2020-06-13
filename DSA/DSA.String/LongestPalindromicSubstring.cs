using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DSA.String
{
    public class LongestPalindromicSubstring
    {
        public string LongestPSubstring()
        {
            string s = Console.ReadLine();

            return Compute(s);
        }

        private string Compute(string s)
        {

            if (string.IsNullOrEmpty(s) || s.Length < 1) return string.Empty;

            string substring = s;

            int start = 0;
            int end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int lenA = ExpandFromMiddle(s, i, i);//this is the case when the length is odd
                int lenB = ExpandFromMiddle(s, i, i + 1);

                int max = Math.Max(lenA, lenB);

                if (max > end - start)
                {
                    //calculate end and start
                    start = i - ((max - 1) / 2);
                    end = i + (max / 2);
                }
            }

            return s.Substring(start, end+1);
        }

        private int ExpandFromMiddle(string s, int left, int right)
        {
            if (s == null || left > right)
                return 0;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;

        }
    }
}
