using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class LC_345_ReverseVowels
    {
        public string reverseVowels(string s)
        {
            if (string.IsNullOrEmpty(s.Trim()) || s.Length == 1)
            {
                return s;
            }
            int start = 0;
            char[] arr = s.ToArray();
            int end = s.Length - 1;

            while (start <= end)
            {
                while(start <= s.Length - 1 && !IsVowel(arr[start]))
                {
                    start++;
                }

                while (end >= 0 && !IsVowel(arr[end]))
                {
                    end--;
                }

                if (start < s.Length && end >= 0 && start <= end)
                {
                    char temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                    end--;
                }

            }

            return new string(arr);
        }

        private bool IsVowel(char an)
        {
            if (an == 'a' || an == 'e' || an == 'i' || an == 'o' || an == 'u' ||
                an == 'A' || an == 'E' || an == 'I' || an == 'O' || an == 'U')
            {
                return true;
            }
            return false;
        }
    }
}
