using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    public class DecodeWays
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();

        public int NumDecodings(string s)
        {
            int count = 0;

            if (Convert.ToInt32(s[0]) == 0)
                return 0;

            for (int i = 0; i < s.Length; i++)
            {
                int currentval = Int32.Parse(s[i].ToString());
                if (currentval <= 26 && currentval > 0)
                {
                    count++;
                }

                if (i < s.Length - 1)
                {
                    currentval = Int32.Parse(s.Substring(i, i + 2));

                    if (currentval <= 26 && currentval > 0)
                    {
                        count++;
                    }
                }
            }

            return count;

        }
        public int recursiveWithMemo(int index, String str)
        {
            // Have we already seen this substring?
            if (memo.ContainsKey(index))
            {
                return memo[index];
            }

            // If you reach the end of the string
            // Return 1 for success.
            if (index == str.Length)
            {
                return 1;
            }

            // If the string starts with a zero, it can't be decoded
            if (str[index] == '0')
            {
                return 0;
            }

            if (index == str.Length - 1)
            {
                return 1;
            }


            int ans = recursiveWithMemo(index + 1, str);
            if (Int32.Parse(str.Substring(index, 2)) <= 26)
            {
                ans += recursiveWithMemo(index + 2, str);
            }

            // Save for memoization
            if(!memo.ContainsKey(index))
                memo.Add(index, ans);

            return ans;
        }

        public int Recursive_NumDecode(int index, string s)
        {
            if(index == s.Length-1 || index == s.Length)
            {
                return 1;
            }

            if(s[index] == '0')
            {
                return 0;
            }
                

            int ans = Recursive_NumDecode(index + 1, s);

            int number = Int32.Parse(s.Substring(index, 2));

            if(number <= 26)
            {
                ans += Recursive_NumDecode(index + 2, s);
            }

            return ans;
        }
    }
}
