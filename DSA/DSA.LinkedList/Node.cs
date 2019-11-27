using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public Node<T> NextNode { get; set; }

        
    }

    public class NodeImpl
    {
        public Node<int> CreateNodeLinking()
        {
            Node<int> thirdNode = new Node<int>(3);


            Node<int> secondNode = new Node<int>(2);
            secondNode.NextNode = thirdNode;

            Node<int> firstNode = new Node<int>(1);
            firstNode.NextNode = secondNode;


            return firstNode;
        }
    }
}
