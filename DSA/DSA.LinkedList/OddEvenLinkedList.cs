using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return null;

            ListNode oddNode = head;
            ListNode evenNode = head.next;
            ListNode even = evenNode;
            while (evenNode != null && evenNode.next != null)
            {
                oddNode.next = evenNode.next;
                oddNode = oddNode.next;
                evenNode.next = oddNode.next;
                evenNode = evenNode.next;
            }

            oddNode.next = even;
            return head;
        }
    }
}
