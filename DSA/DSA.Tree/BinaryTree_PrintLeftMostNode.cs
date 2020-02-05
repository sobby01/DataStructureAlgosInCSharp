using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BinaryTree_PrintLeftMostNode
    {
        public void PrintLeftView(TreeNode rootNode)
        {
            //Using BFS
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(rootNode);

            while (queue.Count >0)
            {
                int count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    if (i == 0)
                        Console.Write(currentNode.val);

                    if(currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);
                    if(currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }
            }
        }

        public void PrintLeftViewUsingDFS(TreeNode rootNode)
        {
            //Using DFS (InOrder Traversal)
        }

        public void PrintRightView(TreeNode rootNode)
        {

        }
    }
}
