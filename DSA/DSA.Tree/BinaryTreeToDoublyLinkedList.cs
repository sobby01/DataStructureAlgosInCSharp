using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BinaryTreeToDoublyLinkedList
    {
        TreeNode prev = null;
        public TreeNode ConvertBTTODLL(TreeNode rootNode)
        {
            if (rootNode == null)
                return rootNode;

            TreeNode headNode = ConvertBTTODLL(rootNode.Left);

            if (prev == null)
                headNode = rootNode;
            else
            {
                prev.Right = rootNode;
                rootNode.Left = prev;
            }

            prev = rootNode;

            ConvertBTTODLL(rootNode.Right);
            return headNode;

        }
    }
}
