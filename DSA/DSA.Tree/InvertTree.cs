using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class InvertTree
    {
        public TreeNode InvertTreeM(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode right = InvertTreeM(root.Right);
            TreeNode left = InvertTreeM(root.Left);
            root.Left = right;
            root.Right = left;
            return root;
        }

        public TreeNode InvertTreeIterative(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while(q.Count > 0)
            {
                TreeNode currentNode = q.Dequeue();
                TreeNode leftNode = currentNode.Left;
                currentNode.Left = currentNode.Right;
                currentNode.Right = leftNode;

                if (currentNode.Left != null)
                    q.Enqueue(currentNode.Left);
                if (currentNode.Right != null)
                    q.Enqueue(currentNode.Right);
            }
            return root;
        }
    }
}
