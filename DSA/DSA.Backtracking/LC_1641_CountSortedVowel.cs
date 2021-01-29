using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Backtracking
{
    public class LC_1641_CountSortedVowel
    {
        public int CountVowelStrings(int n)
        {
            return countStrings(n, 1);
        }

        public int countStrings(int n, int value)
        {
            if (n == 0)
                return 1;
            int result = 0;
            for (int i = value; i <= 5; i++)
            {
                result += countStrings(n - 1, i);
            }

            return result;
        }
    }
}
