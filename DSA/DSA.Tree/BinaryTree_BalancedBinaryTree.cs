using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BinaryTree_BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            int leftTree = 0;
            int rightTree = 0;

            if (root == null)
                return true;

            leftTree = CalculateDepth(root.Left);
            rightTree= CalculateDepth(root.Right);

            if (Math.Abs(leftTree - rightTree) <= 1 && IsBalanced(root.Left) && IsBalanced(root.Right))
                return true;

            return false;
        }

        private int CalculateDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(CalculateDepth(root.Left), CalculateDepth(root.Right));
        }
    }
}
