using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BinaryTree_Height
    {
        public int CalculateHeight(TreeNode rooTreeNode)
        {
            if (rooTreeNode == null)
                return 0;

            int heightOfLeftTree = CalculateHeight(rooTreeNode.Left);
            int heightOfRightTree = CalculateHeight(rooTreeNode.Right);

            int maxOfTrees = Math.Max(heightOfLeftTree, heightOfRightTree);
            int currentHeight = maxOfTrees + 1;
            return currentHeight;
        }
    }
}
