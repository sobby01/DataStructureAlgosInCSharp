using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Maths
{
    public class FindDigits
    {
        public double FindDigit(double number)
        {
            double numberOfDigits = Math.Log10(number) + 1;

            return Math.Floor(Math.Abs(numberOfDigits));
        }
    }
}
