using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class LinkedListDetectCycle
    {
        public bool DetectCycle(ListNode head)
        {
            ListNode slowPointer = head;
            ListNode fastPointer = head;

            while (slowPointer != null && fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;

                if (slowPointer == fastPointer)
                {
                    return true;
                }
            }

            return false;
        }

        public ListNode detectCycleByStart(ListNode head)
        {
            ListNode slowPointer = head;
            ListNode fastPointer = head;

            while (slowPointer != null && fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;

                if (slowPointer == fastPointer)
                {
                    fastPointer = head;
                    while (slowPointer != null && fastPointer != null
                                               && slowPointer != fastPointer)
                    {

                        slowPointer = slowPointer.next;
                        fastPointer = fastPointer.next;

                    }

                    return slowPointer;
                }
            }

            return null;
        }
    }
}
