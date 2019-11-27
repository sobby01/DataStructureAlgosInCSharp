using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class StackWithLinkedList<T> : IEnumerable<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();

        public void Push(T item)
        {
            _list.AddFirst(item);
        }

        public T Pop()
        {
            if (_list.Count == 0)
            {
                throw new Exception("The stack is empty");    
            }

            T value = _list.First.Value;
            _list.RemoveFirst();

            return value;
        }

        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new Exception("The stack is empty");
            }

            T value = _list.First.Value;
            return value;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
