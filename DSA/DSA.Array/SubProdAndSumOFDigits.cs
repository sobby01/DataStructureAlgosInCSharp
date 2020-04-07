using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    /*
     *  Input: n = 234
        Output: 15 
        Explanation: 
        Product of digits = 2 * 3 * 4 = 24 
        Sum of digits = 2 + 3 + 4 = 9 
        Result = 24 - 9 = 15
     */
    public class SubProdAndSumOFDigits
    {
        public int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;
            int r = 0;
            while (n != 0)
            {
                r = n % 10;
                n = n / 10;
                product = product * r;
                sum = sum + r;
            }

            return product - sum;
        }
    }
}
