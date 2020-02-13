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
