using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace increasing_tree.tests
{
    [TestClass]
    public class SolutionTests
    {
        Solution sol = new Solution();

        [TestInitialize]
        public void SetUp()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void NoItem()
        {
            Assert.IsNull(sol.IncreasingBST(null));
        }

        [TestMethod]
        public void OneItem()
        {
            var root = new TreeNode(1);
            TreeNode actual = sol.IncreasingBST(root);
            LeafNodeAssert(1, actual);
        }

        [TestMethod]
        public void twoItemOfRight()
        {
            var root = new TreeNode(1);
            root.right = new TreeNode(2);

            TreeNode actual = sol.IncreasingBST(root);
            NodeAssert(1, actual);
            LeafNodeAssert(2, actual.right);

        }

        [TestMethod]
        public void twoItemOfLeft()
        {
            var root = new TreeNode(2);
            root.left = new TreeNode(1);

            TreeNode actual = sol.IncreasingBST(root);
            NodeAssert(1, actual);
            LeafNodeAssert(2, actual.right);

        }

        [TestMethod]
        public void threeItem()
        {
            var root = new TreeNode(1);
            root.right = new TreeNode(3);
            root.right.left = new TreeNode(2);

            TreeNode actual = sol.IncreasingBST(root);
            NodeAssert(1, actual);
            NodeAssert(2, actual.right);
            LeafNodeAssert(3, actual.right.right);
        }

        private void NodeAssert(int expectVal, TreeNode actual)
        {
            Assert.AreEqual(expectVal, actual.val);
            Assert.IsNull(actual.left);
            Assert.IsNotNull(actual.right);
        }
        private void LeafNodeAssert(int expectVal, TreeNode actual)
        {
            Assert.AreEqual(expectVal, actual.val);
            Assert.IsNull(actual.left);
            Assert.IsNull(actual.right);
        }
    }
}
