using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class MiddleLinkedlist
    {
        public class Solution
        {
            public ListNode MiddleNode(ListNode head)
            {
                ListNode slowPointer = head;
                ListNode fastPointer = head;

                while (fastPointer.next != null)
                {
                    slowPointer = slowPointer.next;
                    if(fastPointer.next.next != null)
                        fastPointer = fastPointer.next.next;
                    else
                    {
                        fastPointer = fastPointer.next;
                    }
                }

                return slowPointer;
            }
        }
    }
}
