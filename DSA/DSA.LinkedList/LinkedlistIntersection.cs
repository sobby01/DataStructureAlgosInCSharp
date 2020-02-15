using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class LinkedlistIntersection
    {
        /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int list1Counter = 0; int list2Counter = 0;

            ListNode firstNode = headA;
            ListNode secondNode = headB;


            while (firstNode != null)
            {
                list1Counter++;
                firstNode = firstNode.next;
            }

            while (secondNode != null)
            {
                list2Counter++;
                secondNode = secondNode.next;
            }

            int diff = list1Counter - list2Counter;
            firstNode = headA;
            secondNode = headB;
            if (diff > 0)
            {
                while (diff > 0)
                {
                    firstNode = firstNode.next;
                    diff--;
                }
            }
            else
            {
                while (diff < 0)
                {
                    secondNode = secondNode.next;
                    diff++;
                }
            }

            while (firstNode != null && secondNode != null)
            {
                if (firstNode == secondNode)
                {
                    return firstNode;
                }

                firstNode = firstNode.next;
                secondNode = secondNode.next;
            }

            return null;
        }
    }
}
