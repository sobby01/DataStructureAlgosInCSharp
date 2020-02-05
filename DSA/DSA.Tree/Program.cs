using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeBuilder objBuilder = new TreeBuilder();
            TreeNode rootNode = objBuilder.Build();

            //BFS_LevelOrderTraversal levelOrder = new BFS_LevelOrderTraversal();
            //levelOrder.PrintLevel(rootNode);
            //BinaryTree_Max bTree = new BinaryTree_Max();
            //int max = bTree.FindMax(rootNode);
            //BinaryTree_Height bTree = new BinaryTree_Height();
            //int height = bTree.CalculateHeight(rootNode);

            //NodesAtKDistance nodes = new NodesAtKDistance();
            //nodes.PrintNodesUsingBFS(rootNode, 2);

            BinaryTree_MaxWidth bTreeMaxWidth = new BinaryTree_MaxWidth();
            int maxWidth = bTreeMaxWidth.MaxWidth(rootNode);

            Console.WriteLine(maxWidth);
            Console.ReadKey();
        }
    }
}
