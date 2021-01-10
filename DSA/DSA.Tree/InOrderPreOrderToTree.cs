using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class InOrderPreOrderToTree
    {
        int index = 0; int rootIndex = 0;

        public TreeNode Construct(int[] inorder, int[] preOrder)
        {
            if (inorder.Length != preOrder.Length)
                return null;

            return BuildTreeRecursive(preOrder, inorder, 0, preOrder.Length-1);
        }

        //[1,2]
        //[2,1]
        public TreeNode BuildTreeRecursive(int[] preorder, int[] inorder, int sIndex, int eIndex)
        {
            //I2 : 0 > 0
            //I3 : 2 > 4
            if (sIndex > eIndex)
            {
                return null;
            }

            TreeNode rootNode = new TreeNode(preorder[index]);
            index++;


            if (sIndex == eIndex)
            {
                return rootNode;
            }

            for (int i = sIndex; i <= eIndex; i++)
            {
                if (inorder[i] == rootNode.val)
                {
                    rootIndex = i;
                    break;
                }
            }

            rootNode.Left = BuildTreeRecursive(preorder, inorder, sIndex, rootIndex - 1);
            rootNode.Right = BuildTreeRecursive(preorder, inorder, rootIndex + 1, eIndex);

            return rootNode;

        }
    }
}
