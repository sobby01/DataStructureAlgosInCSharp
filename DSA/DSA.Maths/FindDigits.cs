using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Maths
{
    public class FindDigits
    {
        /// <summary>
        /// Explaination :
        /// number of digits in N = log10(N) + 1.
        /// Suppose the number of digits in the number N is K.
        /// 10K-1 < N < 1
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double FindDigit(double number)
        {
            double numberOfDigits = Math.Log10(number) + 1;

            return Math.Floor(Math.Abs(numberOfDigits));
        }
    }
}
