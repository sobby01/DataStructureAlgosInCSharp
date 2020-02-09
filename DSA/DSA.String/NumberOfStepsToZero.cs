using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class NumberOfStepsToZero
    {
        //Input: num = 14
        //Output: 6
        //Explanation: 
        //Step 1) 14 is even; divide by 2 and obtain 7. 
        //Step 2) 7 is odd; subtract 1 and obtain 6.
        //Step 3) 6 is even; divide by 2 and obtain 3. 
        //Step 4) 3 is odd; subtract 1 and obtain 2. 
        //Step 5) 2 is even; divide by 2 and obtain 1. 
        //Step 6) 1 is odd; subtract 1 and obtain 0.

        public int NumberOfSteps(int num)
        {
            int numberOfStep = 0;

            if (string.IsNullOrWhiteSpace(num.ToString()) || num == 0)
            {
                return numberOfStep;
            }
            
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num -= 1;
                }

                numberOfStep++;
            }

            return numberOfStep;
        }

    }
}
