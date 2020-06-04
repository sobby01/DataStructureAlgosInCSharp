using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class Reverse
    {
        public void ReverseString(char[] s)
        {
            RevString(s, 0);

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
        }

        private void RevString(char[] s, int index)
        {
            if (index < 0 || index == s.Length/2)
            {
                return;
            }

            RevString(s, index + 1);
            char temp = s[s.Length - index -1];
            s[s.Length - index - 1] = s[index];
            s[index] = temp;
        }
    }
}
