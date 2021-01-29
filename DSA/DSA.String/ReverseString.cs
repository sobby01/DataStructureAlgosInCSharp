using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class ReverseString
    {
        public string solve(string A)
        {
            if (!A.Contains(" "))
            {
                return A;
            }
            StringBuilder sb = new StringBuilder();
            int endLength = A.Length - 1;
            int startLength = 0;
            string str = string.Empty;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] == ' ')
                {
                    startLength = i + 1;

                    str = A.Substring(startLength, endLength - startLength + 1);
                    str = str.Trim();
                    if (!string.IsNullOrEmpty(str))
                    {
                        sb.Append(str);
                        sb.Append(" ");
                        endLength = i - 1;
                    }
                    
                }
            }

            str = A.Substring(0, endLength - 0 + 1);
            sb.Append(str);

            return sb.ToString().Trim();
        }

        public string ReverseWords(string s)
        {
            string[] splittedString = s.Split(' ');
            StringBuilder builder = new StringBuilder();

            foreach (var word in splittedString)
            {
                for (int indexer = word.Length-1; indexer >= 0; indexer--)
                {
                    builder.Append(word[indexer]);
                }

                builder.Append(" ");
            }

            return builder.ToString().TrimEnd();
        }

        /// <summary>
        /// In case want to write our own split method.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string[] split(string s)
        {
            ArrayList words = new ArrayList();
            StringBuilder word = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    words.Add(word.ToString());
                    word = new StringBuilder();
                }
                else
                    word.Append(s[i]);
            }
            words.Add(word.ToString());
            return (string[]) words.ToArray();
        }
    }
}
