using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BinaryTree_MinDepth
    {
        public int MinDepth(TreeNode root)
        {
            return MinimumDepth(root);
        }

        private int MinimumDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.Left == null && root.Right == null)
                return 1;


            if (root.Left == null)
                return MinimumDepth(root.Right) +1;

            if (root.Right == null)
                return MinimumDepth(root.Left) + 1;

            return Math.Min(MinimumDepth(root.Left), MinimumDepth(root.Right)) + 1;
        }
    }
}
