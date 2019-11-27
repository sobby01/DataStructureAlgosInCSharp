using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class PostfixCalculator
    {
        Stack<int> values =new Stack<int>();
        public int CalculatePostFixExpression(string[] expression)
        {
            foreach (var tokenArg in expression)
            {
                int value;

                if (int.TryParse(tokenArg, out value))
                {
                    values.Push(value);
                }
                else
                {
                    int rhs = values.Pop();
                    int lhs = values.Pop();

                    switch (tokenArg)
                    {
                        case "+":
                            values.Push(rhs + lhs);
                            break;
                        case "-":
                            values.Push(lhs - rhs);
                            break;
                        case "*":
                            values.Push(lhs * rhs);
                            break;
                        case "/":
                            values.Push(lhs / rhs);
                            break;
                        case "%":
                            values.Push(lhs % rhs);
                            break;
                    }
                }
            }
            int finalVal = values.Pop();

            return finalVal;
        }
    }
}
