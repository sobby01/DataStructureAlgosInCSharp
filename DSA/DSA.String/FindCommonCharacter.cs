using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class FindCommonCharacter
    {

        /*
         ["acabcddd","bcbdbcbd","baddbadb","cbdddcac","aacbcccd","ccccddda","cababaab","addcaccd"]
         * Input: ["bella","label","roller"]
Output: ["e","l","l"]
         *
         * Input: ["cool","lock","cook"]
Output: ["c","o"]
         */
        public IList<string> CommonChars(string[] A)
        {
            int[,] chars = new int[A.Length, 26];
            IList<string> result = new List<string>();

            for (int i = 0; i < A.Length; i++)
                foreach (var item in A[i])
                    chars[i, item - 'a']++;

            for (int i = 0; i < 26; i++)
            {
                int min = Int32.MaxValue;

                for (int j = 0; j < A.Length; j++)
                    if (chars[j, i] < min)
                        min = chars[j, i];

                if (min > 0)
                    for (int j = 0; j < min; j++)
                        result.Add(((char) (i + 'a')).ToString());
            }

            return result;
        }

        public IList<string> CommonChars_1(string[] A)
        {
            int[,] characterMapper = new int[A.Length, 26];

            IList<string> outputList = new List<string>();

            for (int indexer = 0; indexer < A.Length; indexer++)
            {
                foreach (var outputString in A[indexer])
                {
                    characterMapper[indexer, outputString - 'a']++;
                }
            }

            for (int lIndexer = 0; lIndexer < 26; lIndexer++)
            {
                int min = int.MaxValue;
                for (int fIndexer = 0; fIndexer < A.Length; fIndexer++)
                {
                    if (characterMapper[fIndexer, lIndexer] < min)
                    {
                        min = characterMapper[fIndexer, lIndexer];
                    }
                }

                if (min > 0)
                {
                    for (int j = 0; j < min; j++)
                    {
                        outputList.Add(((char)(lIndexer + 'a')).ToString());
                    }
                }
            }

            return outputList;
        }
    }
}
