using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BST_RangeSum
    {
        private int rangeSumRecursive = 0;
        public int rangeSumBST(TreeNode root, int l, int r)
        {
            int rangeSum = 0;

            Stack<TreeNode> treeStack = new Stack<TreeNode>();
            treeStack.Push(root);

            while (treeStack.Count > 0)
            {
                TreeNode node = treeStack.Pop();

                if (node.val >= l && node.val <= r)
                {
                    rangeSum += node.val;
                }

                if (node.val > l && node.Left != null)
                {
                    treeStack.Push(node.Left);
                }
                else if (node.val < r && node.Right != null)
                {
                    treeStack.Push(node.Right);
                }
            }

            return rangeSum;
        }

        public int RangesumBase(TreeNode root, int L, int R)
        {
            rangeSumRecursive = 0;
            rangeSumBSTRecursive(root, L, R);
            return rangeSumRecursive;
        }

        public void rangeSumBSTRecursive(TreeNode root, int l, int r)
        {
            while (root != null)
            {
                if (root.val >= l && root.val <= r)
                {
                    rangeSumRecursive += root.val;
                }

                if (root.val > l && root.Left != null)
                {
                    rangeSumBSTRecursive(root.Left, l, r);
                }
                else if (root.val < r && root.Right != null)
                {
                    rangeSumBSTRecursive(root.Right, l, r);
                }
            }
        }
    }
}
