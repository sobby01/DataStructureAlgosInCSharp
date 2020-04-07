using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    public class Node
    {
        public Node Next
        {
            get; set;
        }

        public int val;

        public Node(int v)
        {
            this.val = v;
        }
    }

    public class QueueUsingLinkedList
    {
        public Node front;
        public Node rear;

        public void Enqueue(int val)
        {
            Node newNode = new Node(val);

            if (front == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public void Dequeue()
        {
            if (front == null)
            {
                Console.Write("Queue is empty");
                return;
            }

            front = front.Next;
        }



    }
}
