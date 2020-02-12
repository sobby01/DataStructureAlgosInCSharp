using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    /*
     * Input: head = [1,0,1]
     * Output: 5
       Explanation: (101) in base 2 = (5) in base 10

        1,0,0,1,0,0,1,1,1,0,0,0,0,0,0

     */
    public class ConvertBinaryNumberToInt
    {
        public int GetDecimalValue(ListNode head)
        {
            int IntValue = 0;
            ListNode currentNode = head;
            int length = 1;
            while (currentNode.next != null)
            {
                length++;
                currentNode = currentNode.next;
            }

            ListNode processingNode = head;
            for (int i = length; i > 0; i--)
            {

                int value = processingNode.val;

                IntValue = IntValue + (int)(value * Math.Pow(2, i-1));
                processingNode = processingNode.next;

            }

            return IntValue;
        }
    }
}
