using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BinaryTree_MaxDepth
    {

        public int MaxDepth(TreeNode root)
        {
            return InorderTraversal(root, 1);
        }

        private int InorderTraversal(TreeNode root, int depth)
        {
            int max = Int32.MinValue; ;

            if (root == null)
            {
                return max;
            }

            
            InorderTraversal(root.Left, depth + 1);

            max = Math.Max(max, depth);

            InorderTraversal(root.Right, depth + 1);

            return max;
        }
    }
}
