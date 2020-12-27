using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class LinkedList_RecursiveSearch
    {
        public int Search(ListNode head, int x)
        {
            if (head == null)
                return -1;

            if (head.val == x)
                return 1;

            int value = Search(head.next, x);

            if (value == -1)
                return -1;
            else
                return value + 1;
        }
    }
}
