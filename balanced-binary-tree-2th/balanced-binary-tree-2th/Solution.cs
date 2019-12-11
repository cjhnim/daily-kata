using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balanced_binary_tree_2th
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            return root == null || IsBalanced(root.left) && IsBalanced(root.right) && checkBalance(root);
        }

        private bool checkBalance(TreeNode root)
        {
            return Math.Abs(getDepth(root.left) - getDepth(root.right)) <= 1;
        }

        private int getDepth(TreeNode node)
        {
            return node == null ? 0 : 1 + Math.Max(getDepth(node.left), getDepth(node.right));
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
