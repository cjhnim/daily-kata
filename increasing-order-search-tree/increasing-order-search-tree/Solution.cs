using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increasing_order_search_tree
{
    public class Solution
    {

        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
                return null;

            var list = new List<TreeNode>();

            inorderTraverse(root, list);

            rearrange(list);

            return list[0];
        }

        private void inorderTraverse(TreeNode root, List<TreeNode> list)
        {

            if (root.left != null)
                inorderTraverse(root.left, list);

            list.Add(root);

            if (root.right != null)
                inorderTraverse(root.right, list);
        }

        private void rearrange(List<TreeNode> list)
        {
            TreeNode tmp = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                tmp.left = null;
                tmp.right = list[i];

                tmp = tmp.right;
            }

            tmp.left = null;
            tmp.right = null;
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
