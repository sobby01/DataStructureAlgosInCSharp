using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class MaxCutsInRod
    {
        //Givena  rod of length n and three numbers a,b,c. We need to find the maximum number of cuts.
        //that we can make in the rod so that every cut is of sixe in the ser (a,b,c)
        //I/P: n = 5, a =a, b =2, c = 3;
        //O/P : 5

        public int MaxCutsSolution(int n, int a, int b, int c)
        {
            if (n == 0) return 0;

            if (n < 0) return -1;

            int maxCut1 = MaxCutsSolution(n - a, a, b, c);
            int maxCut2 = MaxCutsSolution(n - b, a, b, c);
            int maxCut3 = MaxCutsSolution(n - c, a, b, c);

            int sol = Math.Max(maxCut1, maxCut2);
            sol = Math.Max(sol, maxCut3);
            if (sol < 0)
                return -1;
            return sol + 1;
        }
    }
}
