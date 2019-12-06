using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increasing_tree
{
    public class Solution
    {
        TreeNode cur;
        
        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
                return null;


            var virtualRoot = new TreeNode(0);
            virtualRoot.right = root;
            cur = virtualRoot;

            inorder(root);

            return virtualRoot.right;
        }

        private void inorder(TreeNode root)
        {
            if (root == null)
                return ;

            inorder(root.left);

            cur.right = root;
            cur = root;
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
