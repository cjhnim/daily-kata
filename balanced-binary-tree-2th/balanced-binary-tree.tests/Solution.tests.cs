using System;
using balanced_binary_tree_2th;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace balanced_binary_tree.tests
{
    [TestClass]
    public class SolutionTest
    {
        Solution sol;
        [TestInitialize]
        public void SetUp()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void null_node_is_balanced()
        {
            Assert.IsTrue(sol.IsBalanced(null));
        }

        [TestMethod]
        public void one_leaf_node_is_balanced()
        {
            var node = new TreeNode(1);
            Assert.IsTrue(sol.IsBalanced(node));
        }

        [TestMethod]
        public void two_depth_node_with_left_node_is_balanced()
        {
            var node = new TreeNode(1);
            node.left = new TreeNode(1);
            Assert.IsTrue(sol.IsBalanced(node));
        }

        [TestMethod]
        public void left_node_with_two_depth_and_right_node_with_zero_depth_is_not_balanced()
        {
            var node = new TreeNode(1);
            node.left = new TreeNode(1);
            node.left.left = new TreeNode(1);
            Assert.IsFalse(sol.IsBalanced(node));
        }

        [TestMethod]
        public void left_node_with_zero_depth_and_right_node_with_two_depth_is_not_balanced()
        {
            var node = new TreeNode(1);
            node.right = new TreeNode(1);
            node.right.right = new TreeNode(1);
            Assert.IsFalse(sol.IsBalanced(node));
        }

        [TestMethod]
        public void root_node_balanced_but_left_sub_node_not_balanced()
        {
            var node = new TreeNode(1);
            node.left = new TreeNode(1);
            node.left.left = new TreeNode(1);
            node.left.left.left = new TreeNode(1);
            node.right = new TreeNode(1);
            node.right.right = new TreeNode(1);
            Assert.IsFalse(sol.IsBalanced(node));
        }

        [TestMethod]
        public void root_node_balanced_but_right_sub_node_not_balanced()
        {
            var node = new TreeNode(1);
            node.left = new TreeNode(1);
            node.left.left = new TreeNode(1);
            node.right = new TreeNode(1);
            node.right.right = new TreeNode(1);
            node.right.right.right = new TreeNode(1);
            Assert.IsFalse(sol.IsBalanced(node));
        }
    }
}
