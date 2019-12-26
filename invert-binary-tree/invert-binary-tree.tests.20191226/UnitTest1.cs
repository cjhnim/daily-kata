using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace invert_binary_tree.tests._20191226
{
    [TestClass]
    public class UnitTest1
    {
        Solution sol;

        [TestInitialize]
        public void SetUp()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void null_node()
        {
            Assert.IsNull(sol.InvertTree(null));
        }

        [TestMethod]
        public void one_node()
        {
            TreeNode root = new TreeNode(1);
            TreeNode actual = sol.InvertTree(root);
            Assert.AreEqual(1, actual.val);
        }

        [TestMethod]
        public void swap_node()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            TreeNode actual = sol.InvertTree(root);

            Assert.AreEqual(1, actual.val);
            Assert.AreEqual(3, actual.left.val);
            Assert.AreEqual(2, actual.right.val);
        }

        [TestMethod]
        public void left_recursive()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right = new TreeNode(3);

            TreeNode actual = sol.InvertTree(root);

            Assert.AreEqual(1, actual.val);
            Assert.AreEqual(3, actual.left.val);
            Assert.AreEqual(2, actual.right.val);
            Assert.AreEqual(5, actual.right.left.val);
            Assert.AreEqual(4, actual.right.right.val);
        }

        [TestMethod]
        public void right_recursive()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right = new TreeNode(3);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            TreeNode actual = sol.InvertTree(root);

            Assert.AreEqual(1, actual.val);
            Assert.AreEqual(3, actual.left.val);
            Assert.AreEqual(7, actual.left.left.val);
            Assert.AreEqual(6, actual.left.right.val);
            Assert.AreEqual(2, actual.right.val);
            Assert.AreEqual(5, actual.right.left.val);
            Assert.AreEqual(4, actual.right.right.val);
        }
    }

    internal class Solution
    {
        public Solution()
        {
        }

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;

            InvertTree(root.left);
            InvertTree(root.right);
            SwapNode(root);

            return root;
        }

        private static void SwapNode(TreeNode root)
        {
            TreeNode left = root.left;
            root.left = root.right;
            root.right = left;
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
