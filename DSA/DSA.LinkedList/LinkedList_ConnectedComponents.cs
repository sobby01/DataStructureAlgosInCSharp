using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class LinkedList_ConnectedComponents
    {
        public int NumComponents(ListNode head, int[] G)
        {
            HashSet<int> groupingList = new HashSet<int>(G);

            int total = 0;

            ListNode currentNode = head;
            while (currentNode != null)
            {
                if (groupingList.Contains(currentNode.val) &&
                    (currentNode.next == null || !groupingList.Contains(currentNode.next.val)))
                {
                    total++;
                }

                currentNode = currentNode.next;
            }

            return total;
        }
    }
}
