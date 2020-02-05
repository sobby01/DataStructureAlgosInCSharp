using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BFS_LevelOrderTraversal
    {
        public void PrintLevel(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode firstNode = queue.Dequeue();

                Console.WriteLine(firstNode.val);

                if(firstNode.Left != null)
                    queue.Enqueue(firstNode.Left);
                if (firstNode.Right != null)
                    queue.Enqueue(firstNode.Right);
            }

        }
    }
}
