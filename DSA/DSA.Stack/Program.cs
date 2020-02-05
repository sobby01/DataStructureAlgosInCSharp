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
            ValidParenthesis vp = new ValidParenthesis();
            vp.IsValid("([]");
        }
    }
}
