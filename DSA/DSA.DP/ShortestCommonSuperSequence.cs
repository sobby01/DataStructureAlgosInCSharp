using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    public class ShortestCommonSuperSequence
    {
        public string ShortestCommonSupersequence(string str1, string str2)
        {
            char[] s1 = str1.ToCharArray();
            char[] s2 = str2.ToCharArray();
            string lcsString = FindLCS(s1, s2);

            StringBuilder sb = new StringBuilder(str1.Length + str2.Length - lcsString.Length);

            int k = 0; int i = 0; int j = 0;

            while (k < lcsString.Length)
            {
                if (s1[i] == lcsString[k] && s2[j] == lcsString[k])
                {
                    sb.Append(lcsString[k]);
                    k++;
                    i++;
                    j++;

                    continue;
                }

                if (s1[i] != lcsString[k])
                {
                    sb.Append(s1[i]);
                    i++;
                }

                if (s2[j] != lcsString[k])
                {
                    sb.Append(s2[j]);
                    j++;
                }

            }


            AppendArray(i, s1, sb);
            AppendArray(j, s2, sb);

            return sb.ToString();
        }

        public void AppendArray(int i, char[] arr, StringBuilder sb)
        {

            for (int j = i; j < arr.Length; j++)
            {
                sb.Append(arr[j]);
            }
        }

        public string FindLCS(char[] s1, char[] s2)
        {
            string[,] dp = new string[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i <= s1.Length; i++)
            {
                dp[i, 0] = "";
            }

            for (int j = 0; j <= s2.Length; j++)
            {
                dp[0, j] = "";
            }


            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {

                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + "" + s1[i - 1];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j].Length > dp[i, j - 1].Length ? dp[i - 1, j] : dp[i, j - 1];
                    }

                }
            }
            return dp[s1.Length, s2.Length];
        }
    }
}
