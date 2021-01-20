using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HProblems
{
    public class IsAlienSorted
    {
        public bool IsAlien(string[] words, string order)
        {

            int[] indexArray = new int[26];

            for (int i = 0; i < order.Length; ++i)
                indexArray[order[i] - 'a'] = i;

            for(int i = 0; i < words.Length; i++)
            {
                string word1 = words[i];
                string word2 = words[i+1];

                for(int j = 0; j < Math.Min(word1.Length, word2.Length); j++)
                {

                    if(word1[j] != word2[j])
                    {
                        if(indexArray[word1[j] - 'a'] > indexArray[word1[j] - 'a'])
                        {
                            return false;
                        }

                        break;
                    }
                }

                if (word1.Length > word2.Length)
                    return false;

            }

            return true;

        }

    }
}
