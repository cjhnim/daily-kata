using System;
using balanced_binary_tree_2th;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace balanced_binary_tree_lecture.tests
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
            Assert.IsTrue(sol.IsBalanced(null));
        }

        [TestMethod]
        public void string_null_node()
        {
            string input = "null";
            Assert.IsTrue(sol.IsBalanced(TreeNode.Create(input)));
        }

        [TestMethod]
        public void only_root_node()
        {
            string input = "1";
            Assert.IsTrue(sol.IsBalanced(TreeNode.Create(input)));
        }

        [TestMethod]
        public void left_two_node()
        {
            string input = "1 2 null 3";
            Assert.IsFalse(sol.IsBalanced(TreeNode.Create(input)));
        }

        [TestMethod]
        public void left_four_node()
        {
            string input = "1 2 5 3 null null 6 4";
            Assert.IsFalse(sol.IsBalanced(TreeNode.Create(input)));
        }
    }
}
