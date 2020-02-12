using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            RemoveOuterParenthesis outerP = new RemoveOuterParenthesis();
            string modifiedString = outerP.Remove("()()");
            modifiedString = outerP.Remove("(()())(())");

            ValidParenthesisWithStar withS = new ValidParenthesisWithStar();
            bool isValid = withS.WithTwoStack("(())((())()()(*)(*()(())())())()()((()())((()))(*");

            ValidParenthesis vp = new ValidParenthesis();
            vp.IsValid("([]");
        }
    }
}
