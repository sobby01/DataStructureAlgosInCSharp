using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class Program
    {
        public static string GetInternalName(string fieldName, List<string> fieldNames)
        {
            StringBuilder internalStringBuilder = new StringBuilder();
            char[] values1 = fieldName.ToCharArray();
            internalStringBuilder.Append("a");//To avoid any hexa decimal character at the first letter.
            Regex reg = new Regex(@"[^a-zA-Z0-9_]");
            string finalField = string.Empty;
            int indexer = 0;
            foreach (char letter in values1)
            {
                if (reg.IsMatch(letter.ToString()))
                {
                    //In case of special character we will get the integer value
                    int value = Convert.ToInt32(letter);
                    if (value < 0)
                    {
                        value = -1 * value;
                    }
                    internalStringBuilder.Append(value);
                }
                else
                {
                    internalStringBuilder.Append(letter);
                }
            }

            //depends of length limit
            //Reason of choosing 90 : we are appending a & we are appending alst 4 digits of ticks
            // and in case still internal names are same 
            //intername_indexer : indexer could be upto 4 digits (_ and 1 to 999)
            if (internalStringBuilder.Length > 90)
            {
                finalField = internalStringBuilder.ToString().Substring(0, 90);
            }
            else
            {
                finalField = internalStringBuilder.ToString();
            }
            //string ticks = DateTime.Now.Ticks.ToString();
            //string changedTicks = ticks.Substring(ticks.Length - 4, 4);
            //finalField = string.Format("{0}_{1}", internalStringBuilder, changedTicks);

            while (fieldNames.Contains(finalField))
            {
                indexer++;
                finalField = string.Format("{0}_{1}", finalField, indexer);
            }

            return finalField;
        }
        public static TreeNode Build()
        {
            TreeNode rootNode = new TreeNode(20);

            TreeNode leftNode = new TreeNode(80);

            TreeNode rightNode = new TreeNode(30);

            rootNode.Left = leftNode;
            rootNode.Right = rightNode;

            leftNode.Left = new TreeNode(40);

            leftNode.Right = new TreeNode(45);

            leftNode.Left.Left = new TreeNode(90);

            return rootNode;
        }

        private static void CheckInternalName()
        {
            Regex invalidChars = new Regex(@"[\\\\<>\[\]'""/;`,?!%]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            string fieldName = "A[]B";

            fieldName = invalidChars.Replace(fieldName, "_");

            Console.WriteLine(fieldName);

            fieldName = "A[~`<>B";

            fieldName = invalidChars.Replace(fieldName, "_");

            Console.WriteLine(fieldName);


            List<string> fieldNames = new List<string>();
            string f1 = "a b";

            string intName = GetInternalName(f1, fieldNames);
            fieldNames.Add(intName);

            string f2 = "a_b";
            intName = GetInternalName(f2, fieldNames);
            fieldNames.Add(intName);

            string f3 = "a-b";
            intName = GetInternalName(f3, fieldNames);
            fieldNames.Add(intName);


            foreach (string name in fieldNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }

        public static TreeNode BuildInvertTree()
        {
            TreeNode rootNode = new TreeNode(4);

            TreeNode leftNode = new TreeNode(2);

            TreeNode rightNode = new TreeNode(7);

            leftNode.Left = new TreeNode(1);
            leftNode.Right = new TreeNode(3);

            rightNode.Left = new TreeNode(6);
            rightNode.Right = new TreeNode(9);

            rootNode.Left = leftNode;
            rootNode.Right = rightNode;

            return rootNode;
        }

        public static TreeNode BuildM1Tree()
        {
            TreeNode rootNode = new TreeNode(1);

            TreeNode leftNode = new TreeNode(3);

            TreeNode rightNode = new TreeNode(2);

            leftNode.Left = new TreeNode(5);

            rootNode.Left = leftNode;
            rootNode.Right = rightNode;

            return rootNode;
        }

        public static TreeNode BuildM2Tree()
        {
            TreeNode rootNode = new TreeNode(2);

            TreeNode leftNode = new TreeNode(1);

            TreeNode rightNode = new TreeNode(3);

            leftNode.Right = new TreeNode(4);

            rightNode.Right = new TreeNode(7);

            rootNode.Left = leftNode;
            rootNode.Right = rightNode;

            return rootNode;
        }

        private static TreeNode PathSumTree() {
            TreeNode rootNode = new TreeNode(10);
            TreeNode leftNode = new TreeNode(5);
            TreeNode rightNode = new TreeNode(-3);
            rootNode.Left = leftNode;
            rootNode.Right = rightNode;
            rightNode.Right = new TreeNode(11);
            TreeNode lNode = new TreeNode(3).Left = new TreeNode(3);
            TreeNode rNode = new TreeNode(2).Right = new TreeNode(1);
            leftNode.Left = lNode;
            leftNode.Right = rNode;
            return rootNode;
        }

        static void Main(string[] args)
        {
            int[] inorder = new int[]
            {
                20,10,40,30,50
            };
            int[] preorder = new int[]
           {
                10,20,30,40,50
           };

            InOrderPreOrderToTree inOrderConversion = new InOrderPreOrderToTree();
            var n1 = inOrderConversion.Construct(inorder, preorder);
            return;

            PathSum ps = new PathSum();
            int count = ps.PathSumBase(PathSumTree(), 8);
            Console.WriteLine(count);
            return;

            TreeNode m1 = BuildM1Tree();

            TreeNode m2 = BuildM2Tree();

            MergeTree mTree = new MergeTree();
            TreeNode mergeTree = mTree.MTreeBuild(m1, m2);


            TreeNode root1 = BuildInvertTree();
            InvertTree iTree = new InvertTree();
            TreeNode rr = iTree.InvertTreeM(root1);

            CheckInternalName();

            TreeNode root = Build();
            BinaryTree_Height treeHeignt = new BinaryTree_Height();
            treeHeignt.CalculateHeight(root);


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
