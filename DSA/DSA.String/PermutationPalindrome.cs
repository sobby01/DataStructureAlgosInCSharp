using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class PermutationPalindrome
    {
       

        public bool IsPalindromicPerm(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            

            for (int i = 0; i < s.Length; i++)
            {
                int val = 0;

                map.TryGetValue(s[i], out val);
                if(val==0)
                    map.Add(s[i], val + 1);
                else
                {
                    map[s[i]] += 1;
                }
            }
            int count = 0;

            foreach (var keyMap in map.Values)
            {
                count += keyMap % 2;
            }

            return count <= 1;  
        }

        public void CheckPalindrome()
        {
            string number1 = Console.ReadLine();

            int number = Convert.ToInt32(number1);

            while (number > 0)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    return;
                int leftIndex = 0;
                int rightIndex = input.Length - 1;

                bool isPalindrome = true;
                while (leftIndex <= rightIndex)
                {
                    if (input[leftIndex] == input[rightIndex])
                    {
                        leftIndex++;
                        rightIndex--;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }

                }

                if (isPalindrome)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                number--;
            }
        }
    }
}
