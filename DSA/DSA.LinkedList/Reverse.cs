using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class Reverse
    {
        /// <summary>
        /// m and n are indexer
        /// </summary>
        /// <param name="head"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (m >= n || head == null  || head.next == null)
            {
                return head;
            }

            ListNode preLeftNode = null;
            ListNode leftNode = head;
            ListNode rightNode= head;

            int leftIndexer = m;
            int rightIndexer = n;
            leftIndexer = leftIndexer - 1;
            // 1,2,3,4,5  //2 and 4
            //leftNode = 2;
            //preLeftNode = 1
            while (leftIndexer > 0)
            {
                preLeftNode = leftNode;
                leftNode = leftNode.next;
                leftIndexer--;
            }

            rightNode = leftNode;
            rightIndexer = rightIndexer - m;
            //RightNode= 4;
            while (rightIndexer > 0)
            {
                rightNode = rightNode.next;
                rightIndexer--;
            }
            //5
            rightNode = rightNode.next;

            ListNode ToNode = rightNode;

            while (leftNode != rightNode)
            {
                ListNode nextNode = leftNode.next;
                leftNode.next = ToNode;
                ToNode = leftNode;
                leftNode = nextNode;
            }
            //List got reversed here.

            if (preLeftNode != null)
            {
                preLeftNode.next = ToNode;
            }
            else
            {
                head = ToNode;
            }

            return head;
        }


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
