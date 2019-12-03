using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace increasing_order_search_tree.tests
{
    [TestClass]
    public class Solution2Tests
    {
        Solution2 sol2;

        [TestInitialize]
        public void SetUp()
        {
            sol2 = new Solution2();
        }

        [TestMethod]
        public void nullItem()
        {
            TreeNode root = null;
            TreeNode result = sol2.IncreasingBST(root);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void oneItem()
        {
            TreeNode root = new TreeNode(1);
            TreeNode result = sol2.IncreasingBST(root);

            LeafNodeAssertAreEqual(1, result);
        }

        [TestMethod]
        public void twoItemOfLeft()
        {
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);

            TreeNode result = sol2.IncreasingBST(root);

            NodeAssertAreEqual(1, result);
            LeafNodeAssertAreEqual(2, result.right);
        }

        [TestMethod]
        public void threeItemOfRight()
        {
            TreeNode root = new TreeNode(2);
            root.right = new TreeNode(4);
            root.right.left = new TreeNode(3);

            TreeNode result = sol2.IncreasingBST(root);

            NodeAssertAreEqual(2, result);
            NodeAssertAreEqual(3, result.right);
            LeafNodeAssertAreEqual(4, result.right.right);
        }

        private static void NodeAssertAreEqual(int expectedVal, TreeNode actual)
        {
            Assert.AreEqual(expectedVal, actual.val);
            Assert.IsNull(actual.left);
            Assert.IsNotNull(actual.right);
        }

        private static void LeafNodeAssertAreEqual(int expectedVal, TreeNode actual)
        {
            Assert.AreEqual(expectedVal, actual.val);
            Assert.IsNull(actual.left);
            Assert.IsNull(actual.right);
        }
    }
}
