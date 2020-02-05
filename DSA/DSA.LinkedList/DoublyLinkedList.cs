using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class DoublyNode<T>
    {
        public DoublyNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public DoublyNode<T> Prev { get; set; }
        public DoublyNode<T> Next { get; set; }
    }

    public class DoublyLinkedList
    {
    }
}
