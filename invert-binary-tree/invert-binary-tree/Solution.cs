using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invert_binary_tree
{
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (null == root)
                return root;

            Swap(root);

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }

        private void Swap(TreeNode root)
        {
            if (null == root)
                return;

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
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
