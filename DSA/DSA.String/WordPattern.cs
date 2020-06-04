using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class WordPattern
    {
        public bool WordPatternMatcher(string pattern, string str)
        {
            Dictionary<string,string> wordMatcher = new Dictionary<string, string>();
            string[] arr = str.Split(' ');
            string pattern1 = string.Empty;
            if (pattern.Length != arr.Length)
            {
                return false;
            }
            for (int i = 0; i < pattern.Length; i++)
            {
                pattern1 = pattern[i].ToString();
                if (wordMatcher.ContainsKey(pattern1))
                {
                    wordMatcher.TryGetValue(pattern1, out var val);

                    if (val != arr[i])
                    {
                        return false;
                    }
                }
                else
                {
                    wordMatcher.Add(pattern1, arr[i]);
                }
            }

            return true;
        }
    }
}
