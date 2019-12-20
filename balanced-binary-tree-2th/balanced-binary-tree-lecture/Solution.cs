using balanced_binary_tree_2th;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balanced_binary_tree_lecture
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            return null == root || IsBalanced(root.left) && IsBalanced(root.right) && IsBalancedNode(root);
        }

        private bool IsBalancedNode(TreeNode root)
        {
            if (root == null)
                return true;

            return Math.Abs(getDepth(root.left) - getDepth(root.right)) < 2;
        }

        private int getDepth(TreeNode node)
        {
            if (null == node)
                return 0;

            return 1 + Math.Max(getDepth(node.left), getDepth(node.right));
        }
    }
}
