using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    public class GenerateNumbersWithGivenNumbers
    {
        public void GenerateNumbers(int a, int b, int total)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(a);
            queue.Enqueue(b);

            for (int i = 0; i < total; i++)
            {
                int current = queue.Dequeue();
                Console.Write(current.ToString() + " ");

                queue.Enqueue(current + a);
                queue.Enqueue(current + b);
            }
        }
    }
}
