using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class AddBinaryStrings
    {
        public string addBinary(string A, string B)
        {
            StringBuilder builder = new StringBuilder();

            if (B.Length > A.Length)
                return addBinary(B, A);
            int maxLength = A.Length;
            int carry = 0; int j = B.Length - 1;
            for (int i = maxLength -1; i >= 0; i--)
            {
                if (A[i] == '1')
                    carry = carry + 1;
                if (j > -1 && j < B.Length && B[j] == '1')
                    carry = carry + 1;

                if (carry % 2 == 1)
                {
                    builder.Append(1);
                }
                else
                {
                    builder.Append(0);
                }
                j--;
                carry = carry / 2;
            }

            if (carry == 1)
                builder.Append('1');

            return new string(builder.ToString().Reverse().ToArray());
        }
    }
}
