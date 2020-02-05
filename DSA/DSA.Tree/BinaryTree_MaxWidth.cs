using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DSA.Tree
{
    public class BinaryTree_MaxWidth
    {
        public int MaxWidth(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int max = 0;
            while (queue.Count > 0)
            {
                int count = queue.Count;
                max = Math.Max(max, count);

                for (int i = 0; i < count; i++)
                {
                    TreeNode currentNode = queue.Dequeue();

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

            return max;

        }
    }
}
