using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class ValidParenthesis
    {
        Stack<char> ParenthesisStack = new Stack<char>();

        public bool IsValid(string s)
        {
            bool isValid = false;
            char[] parenthesisArray = s.ToCharArray();

            if (string.IsNullOrEmpty(s))
                return true;

            foreach (char parenthesis in parenthesisArray)
            {
                if (parenthesis == '{' || parenthesis == '[' || parenthesis == '(')
                {
                    ParenthesisStack.Push(parenthesis);
                }
                else
                {
                    if (ParenthesisStack.Count == 0)
                    {
                        return false;
                    }

                    char matchingParenthesis = ParenthesisStack.Pop();

                    if (matchingParenthesis == '(' && parenthesis == ')')
                    {
                        isValid = true;
                    }
                    else if (matchingParenthesis == '{' && parenthesis == '}')
                    {
                        isValid = true;
                    }
                    else if (matchingParenthesis == '[' && parenthesis == ']')
                    {
                        isValid = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (isValid && ParenthesisStack.Count != 0)
            {
                isValid = false;
            }
            

            return isValid;
        }

    }
}
