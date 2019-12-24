using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace invert_binary_tree.tests
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
        public void null_root()
        {
            TreeNode root = null;

            Assert.IsNull(sol.InvertTree(root));            
        }

        [TestMethod]
        public void one_root()
        {
            TreeNode root = new TreeNode(1);

            TreeNode actual = sol.InvertTree(root);

            Assert.AreEqual(1, actual.val);
            Assert.IsNull(actual.left);
            Assert.IsNull(actual.right);
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
        public void traverse_node()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right  = new TreeNode(7);

            TreeNode actual = sol.InvertTree(root);

            Assert.AreEqual(1, actual.val);
            Assert.AreEqual(5, actual.left.val);
            Assert.AreEqual(7, actual.left.left.val);
            Assert.AreEqual(6, actual.left.right.val);
            Assert.AreEqual(2, actual.right.val);
            Assert.AreEqual(4, actual.right.left.val);
            Assert.AreEqual(3, actual.right.right.val);
        }
    }
}
