using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class ReverseInteger
    {

        //TestCase : -2147483648
        public int Reverse(int x)
        {
            bool isNegative = (x < 0);
            if (isNegative)
            {
                x = x * -1;
            }

            int number = 0;
            int r = 0;
            int currentNumber = x;

            while (currentNumber != 0)
            {
                r = currentNumber % 10;

                if (number > 214748364) return 0;


                number = number * 10 + r;
                currentNumber = currentNumber / 10;

                if (number < 0) return 0;
            }

            if (isNegative)
            {
                return number * -1;
            }

            return number;
        }
    }
}
