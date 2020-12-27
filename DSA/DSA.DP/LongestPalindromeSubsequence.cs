using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DP
{
    public class LongestPalindromeSubsequence
    {
        public int LongestPalindromeSubseq(string s)
        {
           
            int[,] dp = new int[s.Length, s.Length];
            for (int diagonals = 0; diagonals < s.Length; diagonals++)
            {
                dp[diagonals, diagonals] = 1;
            }
            //a g b d b a
            //a g b d b d
            for (int i = s.Length - 1; i >= 0; i--)
            {
                //d : dbd : 3
                //a : abdba : 5
                //b : b d b a : 3
                //a
                //b-> a
                //
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        dp[i,j] = 2 + dp[i + 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i + 1, j]);
                    }
                }
            }

            return dp[0, s.Length - 1];

        }


        public void PrintLongestPalindromeSubseq(string s)
        {          
            int maxValue = 0;
            int j = 0;
            int[,] dp = new int[s.Length, s.Length];
            for (int diagonals = 0; diagonals < s.Length; diagonals++)
            {
                dp[diagonals, diagonals] = 1;
            }

            for (int i = s.Length - 1; i >= 0; i--)
            {
                for (j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        dp[i, j] = 2 + dp[i + 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i + 1, j]);
                    }
                }
            }
            
            j = s.Length -1;
            maxValue = dp[0, j];
            int startPointer = 0;
            int endPointer = maxValue -1;
            char[] resultArray = new char[maxValue];
            for (int i = 0; i< s.Length;)
            {
                if(startPointer <= endPointer)
                {
                    if (j < s.Length && s[i] == s[j])
                    {
                        resultArray[startPointer] = s[i];
                        resultArray[endPointer] = s[j];
                        endPointer--;
                        startPointer++;
                        i++; j--;
                    }
                    else
                    {
                        int maxD = Math.Max(dp[i + 1, j], dp[i, j - 1]);

                        if (dp[i + 1, j] == maxD)
                        {
                            i = i + 1;
                        }
                        else
                        {
                            j = j - 1;
                        }
                    }
                }
                else
                {
                    break;
                }
                
            }

            for(int i =0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
            Console.Write("\n");
        }
    }
}
