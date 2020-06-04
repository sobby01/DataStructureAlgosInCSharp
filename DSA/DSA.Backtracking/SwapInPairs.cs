using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Backtracking
{
    public class SwapInPairs
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode SwapPairs(ListNode head)
        {
            ListNode[] listNodeArray = new ListNode[4];
            listNodeArray[0] = new ListNode();

            if (head != null && head.next != null)
            {
                ListNode firstNode = head;
                ListNode secondNode = head.next;
                firstNode.next = SwapPairs(head.next.next);
                secondNode.next = firstNode;

                return secondNode;
            }

            return head;
        }

        public ListNode SwapNodesIterative(ListNode head)
        {
            ListNode dummyNode = new ListNode(-1);
            dummyNode.next = head;

            ListNode prevNode = dummyNode;
            while (head != null && head.next != null)
            {
                ListNode firstNode = head;
                ListNode secondNode = head.next;

                prevNode.next = secondNode;
                firstNode.next = secondNode.next;
                secondNode.next = firstNode;


                prevNode = firstNode;
                head = firstNode.next;
            }

            return dummyNode.next;
        }
    }
}
