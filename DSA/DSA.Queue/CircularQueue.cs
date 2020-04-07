using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    public class CircularQueue
    {
        private int[] elements;
        private int count = 0;
        private int max;
        private int front;
        private int rear;

        public CircularQueue(int size)
        {
            elements = new int[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;
        }

        public void Insert(int item)
        {
            if (count == max)
            {
                Console.WriteLine("Queue Overflow");
            }
            else
            {
                rear = (rear + 1) % max;
                elements[rear] = item;
                count++;
            }
        }

        public void Delete()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                front = (front + 1) % max;
                count--;
            }
        }

        public void printQueue()
        {
            int i = 0;
            int j = 0;

            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (i = front; j < count;)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + elements[i]);

                    i = (i + 1) % max;
                    j++;

                }
            }
        }
    }
}
