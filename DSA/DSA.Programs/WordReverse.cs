using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Programs
{
    public static class WordReverse
    {
        public static string ReverseWords(string words)
        {
            StringBuilder stringB = new StringBuilder(words.Length);
            var splittedWords = words.Split(" ".ToCharArray());

            for (int len = splittedWords.Length-1; len>=0;len--)
            {
                Console.Write(splittedWords[len] + " ");
                stringB.Append(splittedWords[len]).Append(" ");

            }

            return stringB.ToString().TrimEnd();
        }
    }
}
