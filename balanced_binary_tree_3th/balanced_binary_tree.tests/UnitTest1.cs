using System;
using balanced_binary_tree_3th;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace balanced_binary_tree.tests
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

        [DataRow(null, null)]
        [DataRow("", null)]
        [DataRow("null", null)]
        [DataTestMethod]
        public void null_node(string input, TreeNode expected)
        {
            TreeNode node = TreeNode.Create(input);

            Assert.AreEqual(expected, node);
        }

        [TestMethod]
        public void node_factory_one_node()
        {
            string input = "1";

            TreeNode node = TreeNode.Create(input);

            Assert.AreEqual(1, node.val);
            Assert.IsNull(node.left);
            Assert.IsNull(node.right);
        }

        [TestMethod]
        public void node_factory_two_node()
        {
            string input = "1 2";

            TreeNode node = TreeNode.Create(input);

            Assert.AreEqual(1, node.val);
            Assert.AreEqual(2, node.left.val);
            Assert.IsNull(node.right);
        }

        [TestMethod]
        public void node_factory_three_node()
        {
            string input = "1 2 3";

            TreeNode node = TreeNode.Create(input);

            Assert.AreEqual(1, node.val);
            LeafNodeAssertAreEqual(2, node.left);
            LeafNodeAssertAreEqual(3, node.right);
        }

        [TestMethod]
        public void node_factory_four_node()
        {
            string input = "1 2 3 4";

            TreeNode node = TreeNode.Create(input);

            Assert.AreEqual(1, node.val);
            Assert.AreEqual(2, node.left.val);
            LeafNodeAssertAreEqual(3, node.right);

            Assert.AreEqual(4, node.left.left.val);
            Assert.IsNull(node.left.right);
        }

        [TestMethod]
        public void containging_null_node()
        {
            string input = "1 null 2";

            TreeNode node = TreeNode.Create(input);

            Assert.AreEqual(1, node.val);
            Assert.IsNull(node.left);
            LeafNodeAssertAreEqual(2, node.right);
        }

        private static void LeafNodeAssertAreEqual(int expected, TreeNode node)
        {
            Assert.AreEqual(expected, node.val);
            Assert.IsNull(node.left);
            Assert.IsNull(node.right);
        }
    }
}