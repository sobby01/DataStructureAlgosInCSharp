using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    //3
    /// \
    //4   5
    /// \
    //1   2
    //Given tree t:
    //4 
    /// \
    //1   2
    //Return true, because t has the same structure and node values with a subtree of s.
    public class IsSubtreeOfAnother
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            return TraverseNodes(s, t);
        }

        public bool TraverseNodes(TreeNode s, TreeNode t)
        {
            if (s != null)
            {
                return IsEqual(s, t) ||
                       TraverseNodes(s.Left, t) ||
                       TraverseNodes(s.Right, t);
            }
            else
            {
                return false;
            }
        }

        public bool IsEqual(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
            {
                return true;
            }

            if (s == null || t == null)
            {
                return false;
            }

            if (s.val == t.val && IsEqual(s.Left, t.Left) && IsEqual(s.Right, t.Right))
            {
                return true;
            }

            return false;
        }
    }
}
