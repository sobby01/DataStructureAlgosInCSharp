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
            //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            ListNode objListNode = new ListNode(2);
            objListNode.next = new ListNode(4);
            objListNode.next.next = new ListNode(3);

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
