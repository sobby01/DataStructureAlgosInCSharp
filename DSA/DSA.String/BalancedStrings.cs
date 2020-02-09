using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class BalancedStrings
    {
        public int BalancedStringSplit(string s)
        {
            int res = 0;
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
                if (counter == 0)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
