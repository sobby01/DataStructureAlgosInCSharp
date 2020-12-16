using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Maths
{
    public class ComputePower
    {
        public int NaiveSolution_Power(int x, int n)
        {
            int result = 1;

            for(int i = 0; i < n; i++)
            {
                result = result * x;
            }

            return result;
        }

        public int EfficientSolution_Power(int x, int n)
        {
            if (n == 0)
                return 1;

            int temp = EfficientSolution_Power(x, n / 2);

            temp = temp * temp;

            if (n % 2 == 0)
                return temp;
            else
                return temp* x;
        }

    }
}
