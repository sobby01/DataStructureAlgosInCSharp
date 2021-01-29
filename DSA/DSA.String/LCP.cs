using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class LCP
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return string.Empty;

            string prefixStr = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefixStr) != 0)
                {
                    prefixStr = prefixStr.Substring(0, prefixStr.Length - 1);
                    if (string.IsNullOrEmpty(prefixStr))
                        return string.Empty;
                }
            }

            return prefixStr;
        }

        public string longestCommonPrefix(List<string> A)
        {

            if (A.Count == 0)
                return string.Empty;

            string prefixStr = A[0];

            for (int i = 1; i < A.Count; i++)
            {
                while (A[i].IndexOf(prefixStr) != 0)
                {
                    prefixStr = prefixStr.Substring(0, prefixStr.Length - 1);
                    if (string.IsNullOrEmpty(prefixStr))
                        return string.Empty;
                }
            }

            return prefixStr;

        }


        public string longestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            return lcp(strs, 0, strs.Length - 1);
        }

        public string LongestCommonPrefix(List<string> A)
        {
            string[] strs = A.ToArray();
            if (strs == null || strs.Length == 0) return "";
            return lcp(strs, 0, strs.Length - 1);
        }

        private string lcp(string[] strs, int l, int r)
        {
            if (l == r)
            {
                return strs[l];
            }
            else
            {
                int mid = (l + r) / 2;
                string lcpLeft = lcp(strs, l, mid);
                string lcpRight = lcp(strs, mid + 1, r);
                return getPrefix(lcpLeft, lcpRight);
            }
        }

        string getPrefix(string left, string right)
        {
            int min = Math.Min(left.Length, right.Length);
            for (int i = 0; i < min; i++)
            {
                if (left[i] != right[i])
                    return left.Substring(0, i);
            }
            return left.Substring(0, min);
        }

    }
}
