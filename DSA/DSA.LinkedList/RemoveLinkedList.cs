using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    /*
     *
     *  Remove all elements from a linked list of integers that have value val.

        Example:

        Input:  1->2->6->3->4->5->6, val = 6
        Output: 1->2->3->4->5
     */
    public class RemoveLinkedList
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;
            if (head.next == null && head.val == val)
            {
                head = null;
                return head;
            }

            ListNode parentNode = new ListNode(0);
            parentNode.next = head;

            ListNode currentNode = head;
            ListNode prevNode = parentNode;
            while (currentNode != null)
            {
                if (currentNode.val == val)
                {
                    prevNode.next = currentNode.next;
                }
                else
                    prevNode = currentNode;

                currentNode = currentNode.next;
            }

            return parentNode.next;
        }
    }
}
