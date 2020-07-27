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
    }
}
