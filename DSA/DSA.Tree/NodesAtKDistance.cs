using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class NodesAtKDistance
    {
        public void PrintNodesUsingDFS(TreeNode rootNode)
        {
            PrintNodes(rootNode, 2);
        }

        private void PrintNodes(TreeNode rootNode, int k)
        {
            if (rootNode == null)
                return;

            if (k == 0)
            {
                Console.Write(rootNode.val);
            }

            PrintNodes(rootNode.Left, k--);
            PrintNodes(rootNode.Right, k--);
        }

        public void PrintNodesUsingBFS(TreeNode rootNode, int k)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(rootNode);
            int counter = -1;

            while (queue.Count > 0)
            {
                for (int i = 0; i < queue.Count; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
 
                    if (counter == k)
                    {
                        Console.Write(currentNode.val + " ");
                        continue;
                    }

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }

                    if (counter < k)
                        counter++;
                }
            }

        }
    }
}
