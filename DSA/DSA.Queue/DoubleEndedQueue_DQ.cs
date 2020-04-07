using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    public class DQNode
    {
        public DQNode prev { get; set; }

        public DQNode next { get; set; }

        public int value { get; set; }

        public DQNode(int val)
        {
            value = val;
        }
    }

    public class DoubleEndedQueue_DQ
    {
        private DQNode front;

        private DQNode rear;

        private int count = 0;

        private int version = 0;


        public void EnqueueFront(int val)
        {
            DQNode dNode = new DQNode(val);
            dNode.next = front;

            if (count > 0)
            {
                front.prev = dNode;
            }

            front = dNode;

            count++;

            if (count == 1)
            {
                rear = front;
            }
        }

        public void EnqueueRear(int val)
        {
            DQNode dNode = new DQNode(val);
            dNode.prev = rear;

            if (count > 0)
            {
                rear.next = dNode;
            }

            rear = dNode;

            count++;

            if (count == 1)
                front = dNode;
        }

        public int DequeueFront()
        { 
            //Queue is empty
            if (count <= 0)
            {

            }

            int val = front.value;

            front = front.next;
            count--;

            if (count > 0)
                front.prev = null;
            else
            {
                rear = null;
            }

            return val;
        }

        public int DequeueRear()
        {
            if (count <= 0)
                return -1;

            int val = rear.value;
            rear = rear.prev;

            count--;

            if (count > 0)
            {
                rear.next = null;
            }
            else
            {
                rear = null;
            }

            return val;
        }

    }
}
