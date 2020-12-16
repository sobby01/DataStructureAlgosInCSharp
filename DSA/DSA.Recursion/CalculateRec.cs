using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class CalculateRec
    {
        int bar(int x, int y)
        {
            if (y == 0) return 0;
            return (x + bar(x, y - 1));
        }

        public int foo(int x, int y)
        {
            if (y == 0) return 1;
            return bar(x, foo(x, y - 1));
        }

        

    }
}
