using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algos
{
    public class KMPAlgo
    {
        int KMPSearch(string pat, string txt)
        {
            int M = pat.Length;
            int N = txt.Length;


            int[] lps = new int[M];
            int j = 0;

            computeLPSArray(pat, M, lps);

            int i = 0;
            int res = 0;
            int next_i = 0;

            while (i < N)
            {
                if (pat[j] == txt[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    j = lps[j - 1];
                    res++;

                    if (lps[j] != 0)
                        i = ++next_i;
                    j = 0;
                }

                else if (i < N && pat[j] != txt[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }
            return res;
        }

        void computeLPSArray(string pat, int M, int[] lps)
        {
            int len = 0;
            int i = 1;
            lps[0] = 0;


            while (i < M)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {

                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else // if (len == 0) 
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
    }
}
