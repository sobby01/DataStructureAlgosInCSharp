using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BinaryTree_Max
    {
        public int FindMax(TreeNode rootNode)
        {
            if (rootNode == null)
            {
                return Int32.MinValue;
            }

            int data = rootNode.val;
            int lMax = FindMax(rootNode.Left);
            int rMax = FindMax(rootNode.Right);

            if (lMax > data)
                data = lMax;
            else if (rMax > data)
                data = rMax;
            return data;
        }
    }
}
