using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class CountAndSay
    {
        public string CountAndSay_Methody(int n)
        {
            StringBuilder sb = new StringBuilder();
            string number = "1";
            if (n == 1)
            {
                return number;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    sb = new StringBuilder();
                    int indexer = 1;
                    char oldNumber = '\0';
                    for (int j = 0; j < number.Length; j++)
                    {
                        if (j != 0)
                        {
                            if (oldNumber == number[j])
                            {
                                indexer++;
                            }
                            else
                            {
                                sb.Append(indexer.ToString());
                                sb.Append(oldNumber.ToString());
                                indexer = 1;
                            }
                        }

                        oldNumber = number[j];
                    }
                    sb.Append(indexer.ToString());
                    sb.Append(oldNumber.ToString());
                    number = sb.ToString();
                }
            }

            return number;
        }
    }
}
