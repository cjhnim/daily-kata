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
            return Method2(root);
        }

        private TreeNode Method1(TreeNode root)
        {
            if (root == null)
                return null;

            var list = new List<TreeNode>();

            inorderTraverse(root, list);

            rearrange(list);

            return list[0];
        }

        TreeNode cur;
        private TreeNode Method2(TreeNode root)
        {
            if (root == null)
                return null;

            var tmpRoot = new TreeNode(0);

            cur = tmpRoot;
            inorderArrange(root);


            return tmpRoot.right;
        }

        private void inorderArrange(TreeNode root)
        {
            if (root == null)
                return;

            inorderArrange(root.left);

            root.left = null;
            cur.right = root;
            cur = root;

            inorderArrange(root.right);
        }

        private void inorderTraverse(TreeNode root, List<TreeNode> list)
        {
            if (root == null)
                return ;

            inorderTraverse(root.left, list);
            list.Add(root);
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
