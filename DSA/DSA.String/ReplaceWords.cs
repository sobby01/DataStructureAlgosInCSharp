using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    //648. Replace Words
    //Try this problem using Trie.
    public class ReplaceWords
    {
        public string replaceWords(IList<string> dict, string sentence)
        {
            StringBuilder replacedWork = new StringBuilder();

            var stringArray = sentence.Split(' ');

            foreach (string word in stringArray)
            {
                replacedWork.Append(matchedString(dict, word));
                replacedWork.Append(" ");
            }

            return replacedWork.ToString().TrimEnd();
        }

        private string matchedString(IList<string> dict, string word)
        {
            foreach (string d in dict)
            {
                if (word.StartsWith(d))
                {
                    return d;
                }
            }

            return word;
        }
    }
}
