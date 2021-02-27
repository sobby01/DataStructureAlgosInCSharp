using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class PermutationString_Recursion
    {
        public void GeneratePermutations(string s)
        {
            GP(ref s, 0);
            int[] s1 = new int[3] { 1, 2, 3 };
            List<List<int>> collection = new List<List<int>>();
            List<int> ss2 = s1.ToList();
            collection.Add(ss2);
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
