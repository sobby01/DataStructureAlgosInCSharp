using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> Head { get; set; }

        private Node<T> Tail { get; set; }

        private int Count { get; set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            var temp = Head;

            Head.NextNode = temp;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        public void AddLast(Node<T> node)
        {
            Node<T> previousNode = null;
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.NextNode = node;
            }

            Tail = node;
            Count++;
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Node<T> previousNode = null;
                    while (Head != Tail)
                    {
                        previousNode = Head;
                        Head = Head.NextNode;
                    }

                    previousNode.NextNode = null;
                    Tail = previousNode;
                }
            }
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.NextNode;
                }

                Count--;
            }
        }
    }
}
