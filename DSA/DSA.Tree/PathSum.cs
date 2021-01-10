using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class PathSum
    {
        public int PathSum2(TreeNode root, int sum)
        {
            if (root == null)
                return 0;

            return PathSumRecursive(root, sum) + PathSum2(root.Left, sum) + PathSum2(root.Right, sum);
        }

        public int PathSumRecursive(TreeNode root, int sum)
        {
            if (root == null)
                return 0;

            int rootSum = 0;
            if (root.val == sum)
                rootSum = 1;

            int currentSum = sum - root.val;

            return rootSum + PathSumRecursive(root.Left, currentSum) + PathSumRecursive(root.Right, currentSum);
        }

        int count = 0;
        public int PathSumBase(TreeNode root, int sum)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1;
            int count = 0;
            PathSum1(root, 0, sum, map);
            return count;
        }

        public void PathSum1(TreeNode root, int sum, int originalSum, Dictionary<int, int> map)
        {
            if (root == null)
                return;

            sum += root.val;

            if (map.ContainsKey(sum - originalSum))
                count += map[sum - originalSum];

            map[sum] = map.ContainsKey(sum) ? ++map[sum] : 1;

            PathSum1(root.Left, sum, originalSum, map);
            PathSum1(root.Right, sum, originalSum, map);

            map[sum]--;
        }
    }
}
