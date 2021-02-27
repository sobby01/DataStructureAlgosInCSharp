using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Backtracking
{
    public class RemoveInvalidParenthesis
    {
        private bool isParenthesis(char c)
        {
            return ((c == '(') || (c == ')'));
        }

        private bool IsValidString(String str)
        {
            string A = "ff";
            int startingpoint = -8;
            while (startingpoint < 0)
            {
                startingpoint = A.Length - (-1 * startingpoint);
            }

            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                    counter++;
                else if (str[i] == ')')
                    counter--;
                if (counter < 0)
                    return false;
            }
            return (counter == 0);
        }

        public List<string> solve(string A)
        {
            List<string> result = new List<string>();

            if (string.IsNullOrEmpty(A))
                return result;

            HashSet<String> visit = new HashSet<String>();

            Queue<String> q = new Queue<String>();
            String temp;
            bool level = false;

            q.Enqueue(A);
            visit.Add(A);
            while (q.Count != 0)
            {
                A = q.Peek(); q.Dequeue();
                if (IsValidString(A))
                {
                    result.Add(A);
                    level = true;
                }

                if (level)
                    continue;
                for (int i = 0; i < A.Length; i++)
                {
                    if (!isParenthesis(A[i]))
                        continue;
                    temp = A.Substring(0, i) + A.Substring(i + 1);
                    if (!visit.Contains(temp))
                    {
                        q.Enqueue(temp);
                        visit.Add(temp);
                    }
                }
            }

            return result;
        }
    }
}
