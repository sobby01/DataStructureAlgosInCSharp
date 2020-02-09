using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class RemoveVowels
    {
        /// <summary>
        /// Remove a,e,i,o,u
        /// </summary>
        /// <param name="vowelsString"></param>
        /// <returns></returns>
        public string Remove(string vowelsString)
        {
            StringBuilder finalString = new StringBuilder();
            int indexer = 0;
            while (indexer < vowelsString.Length)
            {
                if (vowelsString[indexer] != 'a' && vowelsString[indexer] != 'e' &&
                    vowelsString[indexer] != 'i' && vowelsString[indexer] != 'o' &&
                    vowelsString[indexer] != 'u')
                {
                    finalString.Append(vowelsString[indexer]);
                }

                indexer++;
            }

            return finalString.ToString();

        }
    }
}
