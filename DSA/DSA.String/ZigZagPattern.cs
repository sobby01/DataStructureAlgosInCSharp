using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class ZigZagPattern
    {
        public string Convert(string s, int numRows)
        {

            if (numRows == 1)
                return s;

            int baseStep = (2 * numRows) - 2;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {

                if (i == 0 || i == numRows - 1)
                {
                    for (int j = i; j < s.Length; j += baseStep)
                    {
                        sb.Append(s[j]);
                    }
                }
                else
                {
                    int step1 = 2 * (numRows - 1 - i);
                    int step2 = baseStep - step1;
                    bool flag = true;
                    int j = i;
                    while (j < s.Length)
                    {
                        sb.Append(s[j]);

                        if (flag)
                        {
                            j = j + step1;
                        }
                        else
                        {
                            j = j + step2;
                        }
                        flag = !flag;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
