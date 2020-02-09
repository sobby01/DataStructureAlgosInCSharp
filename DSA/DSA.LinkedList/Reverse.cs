using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class Reverse
    {
        public ListNode ReverseLinkedlist(ListNode node)
        {
            ListNode prevNode = null;
            ListNode currentNode = node;
            ListNode nextNode = null;

            while (currentNode!= null)
            {
                nextNode = currentNode.next;
                currentNode.next = prevNode;

                prevNode = currentNode;
                currentNode = nextNode;
                
            }

            node = prevNode;

            return node;
        }
    }
}
