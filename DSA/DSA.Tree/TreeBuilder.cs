using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class TreeBuilder
    {
        public TreeNode Build()
        {
            TreeNode rootNode = new TreeNode(20);

            TreeNode leftNode = new TreeNode(80);

            TreeNode rightNode = new TreeNode(30);

            rootNode.Left = leftNode;
            rootNode.Right = rightNode;

            leftNode.Left = new TreeNode(40);

            leftNode.Right = new TreeNode(45);

            rightNode.Left = new TreeNode(20);

            rightNode.Right = new TreeNode(50);

            rightNode.Right.Right = new TreeNode(90);

            return rootNode;
        }
    }
}
