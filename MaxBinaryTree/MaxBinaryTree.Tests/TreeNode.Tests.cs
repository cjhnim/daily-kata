using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaxBinaryTree.Tests
{
    [TestClass]
    public class TreeNodeTests
    {
        [TestMethod]
        public void CanInitiate()
        {
            var treeNode = new TreeNode();
        }

        [TestMethod]
        public void OneNode()
        {
            int[] input = { 3 };
            TreeNode treeNode = new MaxBinaryTreeCreator().ConstructMaximumBinaryTree(ref input);

            Assert.AreEqual(3, treeNode.val);
            Assert.IsNull(treeNode.left);
            Assert.IsNull(treeNode.right);
        }

        [TestMethod]
        public void TwoNode_gt()
        {
            int[] input = { 5, 3 };
            TreeNode treeNode = new MaxBinaryTreeCreator().ConstructMaximumBinaryTree(ref input);

            Assert.AreEqual(5, treeNode.val);
            Assert.IsNull(treeNode.left);
            Assert.AreEqual(3, treeNode.right.val);
        }

        public void AssertNode(ref TreeNode treeNode, int value, ref int leftValue, ref int rightValue)
        {
            Assert.AreEqual(value, treeNode.val);

            if (leftValue == null)
                Assert.IsNull(treeNode.left);
            Assert.AreEqual(leftValue, treeNode.left.val);

            if (rightValue == null)
                Assert.IsNull(treeNode.right);
            Assert.AreEqual(rightValue, treeNode.right.val);

        }

        [TestMethod]
        public void TwoNode_lt()
        {
            int[] input = { 3, 5 };
            TreeNode treeNode = new MaxBinaryTreeCreator().ConstructMaximumBinaryTree(ref input);

            Assert.AreEqual(5, treeNode.val);
            Assert.IsNull(treeNode.right);
            Assert.AreEqual(3, treeNode.left.val);
        }

        [TestMethod]
        public void ThreeNode_lt()
        {
            int[] input = { 5, 3, 1 };
            TreeNode treeNode = new MaxBinaryTreeCreator().ConstructMaximumBinaryTree(ref input);

            Assert.AreEqual(5, treeNode.val);
            Assert.IsNull(treeNode.left);
            Assert.AreEqual(3, treeNode.right.val);
            Assert.IsNull(treeNode.right.left);
            Assert.AreEqual(1, treeNode.right.right.val);
        }

        [TestMethod]
        public void Final()
        {
            int[] input = { 3, 2, 1, 6, 0, 5 };
            TreeNode treeNode = new MaxBinaryTreeCreator().ConstructMaximumBinaryTree(ref input);

            Assert.AreEqual(6,    treeNode.val);
            Assert.AreEqual(3,    treeNode.left.val);
            Assert.AreEqual(5,    treeNode.right.val);
            Assert.AreEqual(null, treeNode.left.left);
            Assert.AreEqual(2,    treeNode.left.right.val);
            Assert.AreEqual(0,    treeNode.right.left.val);
            Assert.AreEqual(null, treeNode.right.right);
            Assert.AreEqual(null, treeNode.left.right.left);
            Assert.AreEqual(1,    treeNode.left.right.right.val);
        }
    }
}
