using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{

    //LeetCode problemnumber : 10
    public class RegularExpression_LC_10
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] dpArray = new bool[s.Length+1,p.Length+1];

            int j = p.Length - 1;
            for (int i = s.Length - 1; i < s.Length; i--)
            {
                if (j >= p.Length)
                {
                    return false;
                }

                if (s[i] == p[j])
                {
                    j--;
                }

                if (p[j] == '*')
                {
                    //then find the previous character in string s and start matching
                    int k = i-1;
                    int k1 = j - 1;
                    while ((k1 < p.Length && k < s.Length) && (p[k1] != s[k] || p[k1] == '.'))
                    {
                        k--;
                    }
                }


                else if (p[j] ==  '.')
                {
                    j--;
                }

            }

            return false;

        }

    }
}
