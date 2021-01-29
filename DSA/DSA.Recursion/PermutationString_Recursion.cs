using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class PermutationString_Recursion
    {
        public void GeneratePalindromes(string s)
        {
            GP(ref s, 0);
        }

        public void GP(ref string s, int i)
        {
            IList<string> ls = new List<string>();
            if (i == s.Length -1)
            {
                Console.WriteLine(s);
                return;
            }
            else
            {
                for(int j = i; j< s.Length; j++)
                {
                    Swap(ref s, i, j);

                    GP(ref s, i + 1);

                    Swap(ref s, j, i);
                }
            }
        }

        private void Swap( ref string s, int first, int second)
        {
            char[] arr = s.ToArray();
            char temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
            s = new string(arr);
        }
    }
}
