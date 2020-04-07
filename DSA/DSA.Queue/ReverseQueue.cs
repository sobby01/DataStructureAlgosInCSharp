using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    public class ReverseQueue
    {

        public void ReverseUsingStack(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        public void ReverseUsingQueue(Queue<int> queue)
        {
            if (queue.Count <= 0)
                return;

            int x = queue.Peek();
            queue.Dequeue();

            ReverseUsingQueue(queue);
            queue.Enqueue(x);
        }
    }
}
