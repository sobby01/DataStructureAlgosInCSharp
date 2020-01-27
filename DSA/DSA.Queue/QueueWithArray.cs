using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    public class QueueWithArray<T>: IEnumerable<T>
    {
        T[] items = new T[0];

        private int size = 0;

        //the index of first item in the queue
        private int head = 0;

        //the index of last item in the queue
        private int tail = -1;

        public void Enqueue(T item)
        {
            if (items.Length == size)
            {
                //create new array of double size

                //int newLength =
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
