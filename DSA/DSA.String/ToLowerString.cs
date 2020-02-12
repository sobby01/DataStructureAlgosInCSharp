using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class ToLowerString
    {
        /// <summary>
        /// HELLO to hello
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ConvertTOLower(string str)
        {
            StringBuilder lowerString = new StringBuilder();
            for (int indexer = 0; indexer < str.Length; indexer++)
            {
                if (str[indexer] - 'A' >= 0 && str[indexer] - 'A' < 26)
                {
                    int n = str[indexer] - 'A';
                    lowerString.Append((char) (str[indexer] + 32));
                }
                else
                {
                    lowerString.Append(str[indexer]);
                }
            }

            return lowerString.ToString();
        }
    }
}
