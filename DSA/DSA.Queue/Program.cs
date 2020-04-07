using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue Q = new CircularQueue(5);

            Q.Insert(10);
            Q.Insert(20);
            Q.Insert(30);
            Q.Insert(40);
            Q.Insert(50);

            Console.WriteLine("Items are : ");
            Q.printQueue();

            Q.Delete();
            Q.Delete();

            Q.Insert(60);
            Q.Insert(70);

            Console.WriteLine("Items are : ");
            Q.printQueue();


            PriorityQueue pq = new PriorityQueue(5);

            pq.Enqueue(1);
            pq.Enqueue(5);
            pq.Enqueue(2);
            pq.Enqueue(3);
            pq.Enqueue(4);

            Console.WriteLine(pq.Peek());
            pq.Dequeue();
            Console.WriteLine(pq.Peek());
            Console.WriteLine(pq.Peek());
            pq.Dequeue();
            Console.WriteLine(pq.Peek());
            Console.WriteLine(pq.Peek());
            Console.ReadKey();
        }
    }
}
