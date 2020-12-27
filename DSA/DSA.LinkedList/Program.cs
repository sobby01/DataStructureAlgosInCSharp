using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1->2->3->4->5
            //
            //[1,0,1]
            //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            ListNode objListNode = new ListNode(1);
            objListNode.next = new ListNode(1);
            //RemoveLinkedList rll = new RemoveLinkedList();
            //rll.RemoveElements(objListNode, 1);

            objListNode.next = new ListNode(2);
            objListNode.next.next = new ListNode(6);
            objListNode.next.next.next = new ListNode(3);
            objListNode.next.next.next.next = new ListNode(4);
            objListNode.next.next.next.next.next = new ListNode(5);
            objListNode.next.next.next.next.next.next = new ListNode(6);

            LinkedList_RecursiveSearch rSearch = new LinkedList_RecursiveSearch();
            int value = rSearch.Search(objListNode, 5);
            Console.WriteLine(value);
            return;

            RemoveLinkedList rll2=new RemoveLinkedList();
            rll2.RemoveElements(objListNode, 6);

            Reverse revInBetween = new Reverse();
            revInBetween.ReverseBetween(objListNode, 2, 4);

            ConvertBinaryNumberToInt toInt = new ConvertBinaryNumberToInt();
            toInt.GetDecimalValue(objListNode);

            //Reverse objRev = new Reverse();
            //objRev.ReverseLinkedlist(objListNode);

            ListNode objListNode1 = new ListNode(5);
            objListNode1.next = new ListNode(6);
            objListNode1.next.next = new ListNode(4);

            AddTwoNumbers twoNumbers = new AddTwoNumbers();
            twoNumbers.addTwoNumbers(objListNode, objListNode1);


            Console.WriteLine("\n Press number for following: \n");
            Console.WriteLine("Press 1 for Node Chain \n");
            Console.WriteLine("Press 2 for Linked List \n");
            Console.WriteLine("Press 3 for Merge Sort \n");
            Console.WriteLine("Press 4 for Quick Sort \n");
            Console.WriteLine("Press 5 for Insertion Sort\n");
            Console.WriteLine("Press 6 for Bucket Sort\n");
            Console.WriteLine("Press 7 for Shell Sort\n");

            string number = Console.ReadLine();
            int result;

            if (int.TryParse(number, out result) && (result > 0 && result <= 7))
            {
                switch (number)
                {
                    case "1":
                        NodeImpl objNodeImpl = new NodeImpl();
                        Node<int> currentNode = objNodeImpl.CreateNodeLinking();

                        while (currentNode != null)
                        {
                            Console.WriteLine(currentNode.Value);

                            currentNode = currentNode.NextNode;
                        }
                        break;
                }
            }


            

            Console.ReadKey();
        }
    }
}
