using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increasing_order_search_tree_lecture
{
    public class Solution
    {
        TreeNode current;

        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
                return null;

            //TreeNode newRoot;
            //if (node.left != null)
            //{
            //    newRoot = node.left;
            //    newRoot.right = node;
            //    node.left = null;
            //}

            TreeNode virtualRoot = new TreeNode(0);

            virtualRoot.right = root;

            current = virtualRoot;

            inorder(root);

            return virtualRoot.right;
        }

        private void inorder(TreeNode root)
        {
            if (root == null)
                return;

            inorder(root.left);

            current.right = root;
            current = root;
            root.left = null;

            inorder(root.right);
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
