using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Maths
{
    public class EnumeratingGCDFromAToB
    {
        private ulong gcd(ulong a, ulong b)
        {
            if (b == 0)
                return a;

            return gcd(b, a % b);
        }

        public string solve(string A, string B)
        {
            ulong a = Convert.ToUInt64(A);
            ulong b = Convert.ToUInt64(B);

            ulong g = gcd(a, b);

            if (g == 1)
                return "1";

            ulong result = a;

            for (ulong i = a + 1; i * i <= g; i++)
            {
                result = gcd(result, i);

                if (result == 1)
                    return "1";

            }

            return result.ToString();
        }
    }
}
