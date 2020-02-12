using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class PositiveIntegerSolutionWithinEquation
    {
        /*
 * // This is the custom function interface.
 * // You should not implement it, or speculate about its implementation
 * public class CustomFunction {
 *     // Returns f(x, y) for any given positive integers x and y.
 *     // Note that f(x, y) is increasing with respect to both x and y.
 *     // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
 *     public int f(int x, int y);
 * };
 */
        public interface ICustomFunction
        {
            int f(int x, int y);
        }

        public class Solution
        {
            public IList<IList<int>> FindSolution(ICustomFunction customfunction, int z)
            {
                IList<IList<int>> solutions = new List<IList<int>>();

                return solutions;
            }
        }
    }
}
