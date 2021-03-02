using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class AnagramSolver
    {
        public int AreAnagrams(string a, string b)
        {
            int count = 0;
            if (a.Length != b.Length)
            {
                return -1;
            }
            else if (a.Equals(b, StringComparison.InvariantCultureIgnoreCase))
            {
                return 0;
            }
            else
            {

                bool isAnagram = true;
                int[] alphabetArray = new int[26];

                for (int i = 0; i < a.Length; i++)
                {

                    alphabetArray[a[i] - 'a']++;
                    alphabetArray[b[i] - 'a']--;
                }

                for (int i = 0; i < 26; i++)
                {

                    if (alphabetArray[i] != 0)
                    {
                        isAnagram = false;
                    }

                }

                if (isAnagram)
                {
                    //Count the steps :
                    count = 0;
                    char[] arr1 = a.ToCharArray();
                    char[] arr2 = b.ToCharArray();
                    int i = 0;
                    int j = 0;
                    int size = b.Length;

                    while (i < size)
                    {

                        j = i;
                        while (arr1[j] != arr2[i])
                        {
                            j += 1;
                        }

                        while (i < j)
                        {

                            char temp = arr1[j];
                            arr1[j] = arr1[j - 1];
                            arr1[j - 1] = temp;
                            j = j - 1;
                            count++;
                        }
                        i = i + 1;

                    }
                }
                else
                {
                    count = -1;
                }
                return count;
            }
        }
    }
}
