using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class Validate_BinarySearchTree
    {
        //Remember to use long in case of boundary value exceptions
        public bool IsValid(TreeNode root)
        {
            return IsBST(root, int.MinValue, int.MaxValue);
        }

        public bool IsValidBST(TreeNode root)
        {
            return IsBST(root, int.MinValue, int.MaxValue);
        }

        private bool IsBST(TreeNode root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }


            if (root.val < min || root.val > max)
            {
                return false;
            }

            return (IsBST(root.Left, min, root.val) &&
                    IsBST(root.Right, root.val, max));
        }
    }
}
