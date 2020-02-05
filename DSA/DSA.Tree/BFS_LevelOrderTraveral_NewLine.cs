using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BFS_LevelOrderTraveral_NewLine
    {
        public void PrintLevel(TreeNode rootNode)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(rootNode);
            queue.Enqueue(null);

            while (queue.Count > 0)
            {
                TreeNode currentNode = queue.Dequeue();

                if (currentNode == null)
                {
                    Console.WriteLine();
                    queue.Enqueue(null);
                    continue;
                }

                Console.Write(currentNode.val);

                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
        }
    }
}
