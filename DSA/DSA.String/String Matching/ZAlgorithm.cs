using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class ZAlgorithm
    {
        private int[] CalculateZArray(string input)
        {
            int[] z = new int[input.Length];
            z[0] = 0;
            int left = 0;
            int right = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (i > right)
                {
                    left = right = i;

                    while (right < input.Length && input[right] == input[right - left]
                    )
                    {
                        right++;
                    }

                    z[i] = right - left;
                    right--;
                }
                else
                {
                    int k1 = i - left;
                    //if value does not stretches till right bound then just copy it.
                    if (z[k1] < right - i + 1)
                    {
                        z[i] = z[k1];
                    }
                    else
                    { 
                        //otherwise try to see if there are more matches.
                        left = i;
                        while (right < input.Length && input[right] == input[right - left])
                        {
                            right++;
                        }
                        z[i] = right - left;
                        right--;
                    }
                }
            }
            return z;
        }

        public List<int> PatternMaching(string text, string pattern)
        {
            List<int> solutions = new List<int>();

            StringBuilder newString = new StringBuilder(text.Length + pattern.Length + 1);

            for (int i = 0; i < pattern.Length; i++)
            {
                newString.Append(pattern[i]);
            }

            newString.Append('$');

            for (int j = 0; j < text.Length; j++)
            {
                newString.Append(text[j]);
            }

            int[] zarray = CalculateZArray(newString.ToString());

            for (int i = 0; i < zarray.Length; i++)
            {
                if (zarray[i] == pattern.Length)
                {
                    solutions.Add(i-pattern.Length - 1);
                }
            }
            return solutions;
        }

    }
}
