using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class StringToAtoi
    {
        public int MyAtoi(string str)
        {
            int myNumber = 0;
            int i = 0;
            int sign = 1;
            //sign (+, -)
            //Ignore space
            //check whether the string is greater than int limit

            if (string.IsNullOrWhiteSpace(str))
                return myNumber;

            if (str[i] == '-')
            {
                sign = -1;
                i++;
            }
            else if (str[i] == '+')
            {
                sign = 1;
                i++;
            }

            while (i < str.Length)
            {
               if (str[i] == ' ')
                {
                    i++;
                }
                else
                {
                    break;
                }
            }

            int validInt = 0;
            for (int j = i; j < str.Length; j++)
            {
                if (int.TryParse(str[j].ToString(), out validInt))
                {
                    int num = str[j] - '0';

                    // We will add this number into returned value
                    //so we are checking with one less number and then compare with the
                    //last digit
                    if (Int32.MaxValue / 10 < myNumber ||
                        Int32.MaxValue / 10 == myNumber &&
                        num > Int32.MaxValue % 10)
                    {
                        return sign == -1 ? Int32.MinValue : Int32.MaxValue;
                    }

                    myNumber = myNumber * 10 + num;
                }
                else
                {
                    break;
                }
            }


            return myNumber * sign;
        }
    }
}
