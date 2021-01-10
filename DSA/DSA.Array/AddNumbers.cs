using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class AddNumbers
    {
        public int AddDigits(int num)
        {
            int sum = 0;

            if (num < 10)
                return num;

            var abc = Math.Ceiling(Math.Log10(num));
            while (abc > 0)
            {

                sum += num % 10;
                num = num / 10;
                abc--;

                if (abc == 0 && sum >= 10)
                {
                    num = sum;
                    sum = 0;
                    abc = Math.Ceiling(Math.Log10(num));
                }
            }

            return sum;

        }
    }
}
