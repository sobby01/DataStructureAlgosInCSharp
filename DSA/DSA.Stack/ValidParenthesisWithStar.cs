using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class ValidParenthesisWithStar
    {
        public bool WithTwoStack(string str)
        {
            Stack<char> openParenthesis = new Stack<char>();
            Stack<char> starStack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '{' || str[i] == '[')
                {
                    openParenthesis.Push(str[i]);
                }
                else if (str[i] == '*')
                {
                    starStack.Push(str[i]);
                }
                else
                {
                    if (openParenthesis.Count == 0 && starStack.Count == 0)
                        return false;
                    char pop = openParenthesis.Peek();

                    if (pop == '(' && str[i] == ')' || pop == '{' && str[i] == '}' ||
                        pop == '[' && str[i] == ']')
                    {
                        openParenthesis.Pop();
                    }
                    else
                    {
                        starStack.Pop();
                    }
                }
            }

            if (openParenthesis.Count > 0)
            {
                if (starStack.Count == 0 ||
                    starStack.Count < openParenthesis.Count)
                {
                    return false;
                }
            }

            while (openParenthesis.Count > 0)
            {
                int value = openParenthesis.Pop();
                if (starStack.Count == 0 || starStack.Pop() < value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
