using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    /*
     *  Input: nums = [12,345,2,6,7896]
        Output: 2
        Explanation: 
        12 contains 2 digits (even number of digits). 
        345 contains 3 digits (odd number of digits). 
        2 contains 1 digit (odd number of digits). 
        6 contains 1 digit (odd number of digits). 
        7896 contains 4 digits (even number of digits). 
        Therefore only 12 and 7896 contain an even number of digits.
     */
    public class NumbersWithEvenDigits
    {
        public int FindNumbers(int[] nums)
        {
            int totalEvenDigit = 0;

            for (int indexer = 0; indexer < nums.Length; indexer++)
            {
                int currentNumber = nums[indexer];
                int currentNumberDigitCount = 0;
                do
                {
                    currentNumber = currentNumber / 10;
                    currentNumberDigitCount++;
                }
                while (Math.Abs(currentNumber) >= 1);

                if (currentNumberDigitCount % 2 == 0)
                {
                    totalEvenDigit = totalEvenDigit + 1;
                }

            }

            return totalEvenDigit;
        }
    }
}
