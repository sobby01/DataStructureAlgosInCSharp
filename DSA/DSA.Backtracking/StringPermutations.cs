using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Backtracking
{
    public class StringPermutations
    {
        public void PrintPermutations(char[] input)
        {
            int[] countArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                countArray[i] = 1;
            }

            PrintAllPermutations(input, new char[input.Length], countArray, 0);

            Console.ReadKey();
        }

        private void PrintAllPermutations(char[] input, char[] result, int[] count, int level)
        {
            if (level == input.Length)
            {
                //it means we found the answer
                foreach (char ch in result)
                {
                    Console.Write($"{ch}");
                }
                Console.WriteLine();
                return;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (count[i] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        result[level] = input[i];
                        count[i]--;
                        PrintAllPermutations(input, result,count,level+1);
                        count[i]++;
                    }
                }
            }
        }

    }
}
