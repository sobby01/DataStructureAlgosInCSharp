using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class DecryptStringFromAToInt
    {
        public string FreqAlphabets(string s)
        {
            StringBuilder finalString = new StringBuilder();
            string currentString = string.Empty;
            for (int indexer = 0; indexer < s.Length; indexer++)
            {
                currentString = "";
                currentString += s[indexer];
                if (indexer + 2 < s.Length)
                {
                    if (s[indexer + 2] == '#')
                    {
                        currentString += s[indexer + 1];
                        indexer += 2;
                    }
                }

                int currentNUmber = Convert.ToInt32(currentString);
                if (currentNUmber >=1 && currentNUmber <= 26)
                {
                    finalString.Append((char)(97 + (currentNUmber - 1)));
                }
                
            }

            return finalString.ToString();
        }
    }
}
