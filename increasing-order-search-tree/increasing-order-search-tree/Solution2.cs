using System;

namespace increasing_order_search_tree
{
    public class Solution2
    {
        TreeNode current;

        public Solution2()
        {
        }

        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
                return root;

            TreeNode head = new TreeNode(0);

            head.right = root;
            current = head;
            inorder(root);

            return head.right;
        }

        private void inorder(TreeNode node)
        {
            if (node == null)
                return;

            leftTraverse(node);
            centerTraverse(node);
            rightTraverse(node);
        }

        private void rightTraverse(TreeNode node)
        {
            inorder(node.right);
        }

        private void centerTraverse(TreeNode node)
        {
            current.right = node;
            current = node;
            node.left = null;
        }

        private void leftTraverse(TreeNode node)
        {
            inorder(node.left);
        }
    }
}