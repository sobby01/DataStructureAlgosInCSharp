using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class MergeTree
    {
        public TreeNode MTreeBuild(TreeNode m1, TreeNode m2)
        {
            if (m1 == null)
                return m2;
            if (m2 == null)
                return m1;

            Queue<TreeNode[]> queue = new Queue<TreeNode[]>();
            queue.Enqueue(new TreeNode[] { m1, m2 });

            while(queue.Count > 0)
            {
                TreeNode[] q = queue.Dequeue();

                if (q[0] == null || q[1] == null)
                {
                    continue;
                }

                q[0].val += q[1].val;

                if (q[0].Left == null)
                    q[0].Left = q[1].Left;
                else
                {
                    queue.Enqueue(new TreeNode[] { q[0].Left, q[1].Left });
                }

                if (q[0].Right == null)
                    q[0].Right = q[1].Right;
                else
                {
                    queue.Enqueue(new TreeNode[] { q[0].Right, q[1].Right });
                }

            }


            return m1;
        }

    }
}
