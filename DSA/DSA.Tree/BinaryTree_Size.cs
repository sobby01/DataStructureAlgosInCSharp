using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BinaryTree_Size
    {
        public int Calculate(TreeNode rootNode)
        {
            if (rootNode == null)
            {
                return 0;
            }
            return 1 + Calculate(rootNode.Left) + Calculate(rootNode.Right);
        }

    }
}
