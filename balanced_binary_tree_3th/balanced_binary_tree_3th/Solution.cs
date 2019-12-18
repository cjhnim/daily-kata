using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balanced_binary_tree_3th
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public static TreeNode Create(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            string[] token = input.Split(' ');

            TreeNode root = createNodeFromTokens(token, 0);
            if (null == root)
                return root;

            root.left = createNodeFromTokens(token, leftChild(0));
            root.right = createNodeFromTokens(token, rightChild(0));

            if (token.Length >= 1)
            {
                for (int i = 0; i < token.Length; i++)
                {
                    TreeNode node = find(root, token[i]);
                    if (null != node)
                    {
                        node.left = createNodeFromTokens(token, leftChild(i));
                        node.right = createNodeFromTokens(token, rightChild(i));
                    }
                }
            }
            return root;
        }

        private static TreeNode find(TreeNode root, string value)
        {
            if (0 == value.CompareTo("null"))
                return null;
            return find(root, int.Parse(value));
        }

        private static TreeNode find(TreeNode root, int value)
        {
            if (root == null || root.val == value)
                return root;

            TreeNode node = find(root.left, value);
            if (node != null)
                return node;

            return find(root.right, value);
        }

        private static int rightChild(int index)
        {
            return leftChild(index) + 1;
        }

        private static TreeNode createNodeFromTokens(string[] token, int index)
        {
            if (index >= token.Length)
                return null;

            if (0 == token[index].CompareTo("null"))
                return null;
            else
                return new TreeNode(int.Parse(token[index]));
        }

        private static int leftChild(int index)
        {
            return 2 * index + 1;
        }
    }
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            if (null == root)
                return true;

            return true;
        }
    }
}
