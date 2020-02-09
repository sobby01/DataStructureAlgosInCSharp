using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class AddTwoNumbers
    {
        //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 0 -> 8
        //Explanation: 342 + 465 = 807.

        public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode curreNode = null;
            ListNode explainNode =null;
            int value = 0;
            int remainder = 0;
            int divider = 0;

            while (l1 != null || l2 != null)
            {
                value = 0;
                if (l1 != null)
                {
                    value += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    value += l2.val;
                    l2 = l2.next;
                }
                value += divider;

                remainder = value % 10;
                
                divider = value / 10;
                if (explainNode == null)
                {
                    explainNode = new ListNode(remainder);
                    curreNode = explainNode;
                }
                else
                {
                    ListNode newNode = new ListNode(remainder);
                    curreNode.next = newNode;
                    curreNode = newNode;
                }
            }

            if (divider > 0)
            {
                ListNode newNode = new ListNode(divider);
                curreNode.next = newNode;
            }
               


            return explainNode;
        }
    }
}
