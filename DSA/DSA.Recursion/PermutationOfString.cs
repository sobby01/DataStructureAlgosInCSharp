using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class PermutationOfString
    {
        public void PrintPermutations(char[] input, char[] result, int[] count, int level)
        {
            if (level == input.Length)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i]);
                }

                Console.Write("\n");

                //We found the answer
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if(count[i] == 0)
                        continue;
                    else
                    {
                        result[level] = input[i];
                        //currently the value is 1 in the count array so
                        // we will reduce it and make it 0
                        count[i]--;
                        PrintPermutations(input, result, count, level + 1);
                        count[i]++;
                        //we will again set it 1
                    }

                }
            }
        }
    }
}
