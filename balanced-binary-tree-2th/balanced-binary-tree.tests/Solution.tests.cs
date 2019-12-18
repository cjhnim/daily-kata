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
            string input = "null";

            Assert.IsTrue(sol.IsBalanced(TreeNode.Create(input)));
        }

        [TestMethod]
        public void one_leaf_node_is_balanced()
        {
            string input = "1";

            Assert.IsTrue(sol.IsBalanced(TreeNode.Create(input)));
        }

        [TestMethod]
        public void two_depth_node_with_left_node_is_balanced()
        {
            string input = "1 2";

            Assert.IsTrue(sol.IsBalanced(TreeNode.Create(input)));
        }

        [TestMethod]
        public void left_node_with_two_depth_and_right_node_with_zero_depth_is_not_balanced()
        {
            string input = "1 2 null 3";
            Assert.IsFalse(sol.IsBalanced(TreeNode.Create(input)));
        }

        [TestMethod]
        public void left_node_with_zero_depth_and_right_node_with_two_depth_is_not_balanced()
        {
            string input = "1 null 2 null null null 3";

            Assert.IsFalse(sol.IsBalanced(TreeNode.Create(input)));
        }

        [TestMethod]
        public void root_node_balanced_but_left_sub_node_not_balanced()
        {
            string input = "1 2 3 4 null null 5 6";

            Assert.IsFalse(sol.IsBalanced(TreeNode.Create(input)));
        }

        [TestMethod]
        public void root_node_balanced_but_right_sub_node_not_balanced()
        {
            string input = "1 2 3 4 null null 5 null null null null null null null 6";

            Assert.IsFalse(sol.IsBalanced(TreeNode.Create(input)));
        }
    }
}
