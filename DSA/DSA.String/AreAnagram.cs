using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class Anagram
    {
        public bool AreAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            char[] charX = str1.ToCharArray();
            char[] charY = str2.ToCharArray();
            Array.Sort(charX);
            Array.Sort(charY);


            for (int i = 0; i < str1.Length; i++)
            {
                if (charX[i] != charY[i])
                    return false;
            }

            return true;
        }


        public bool AreAnagramWithHash(string str1, string str2)
        {
            int[] countCharacters = new int[26];

            if (str1.Length != str2.Length)
                return false;

            for (int i = 0; i < str1.Length; i++)
            {
                countCharacters[str1[i] - 'a']++;
                countCharacters[str2[i] - 'a']--;
            }

            for (int counter = 0; counter < countCharacters.Length; counter++)
            {
                if (countCharacters[counter] != 0)
                    return false;
            }

            return true;
        }
    }
}
