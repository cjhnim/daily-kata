using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace increasing_order_search_tree_lecture.tests
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
        public void nullItem()
        {
            TreeNode node = null;

            TreeNode result = sol.IncreasingBST(node);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void oneItem()
        {
            var root = new TreeNode(1);

            TreeNode result = sol.IncreasingBST(root);

            LeafNodeAssert(1, result);
        }

        [TestMethod]
        public void twoItem()
        {
            var root = new TreeNode(2);
            root.left = new TreeNode(1);

            TreeNode result = sol.IncreasingBST(root);

            NodeAssert(1, result);
            LeafNodeAssert(2, result.right);
        }


        [TestMethod]
        public void fourItem()
        {
            var root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(4);
            root.right.left = new TreeNode(3);

            TreeNode result = sol.IncreasingBST(root);

            NodeAssert(1, result);
            NodeAssert(2, result.right);
            NodeAssert(3, result.right.right);
            LeafNodeAssert(4, result.right.right.right);
        }

        private static void NodeAssert(int expect, TreeNode result)
        {
            Assert.AreEqual(expect, result.val);
            Assert.IsNull(result.left);
            Assert.IsNotNull(result.right);
        }
        private void LeafNodeAssert(int expect, TreeNode actual)
        {
            Assert.AreEqual(expect, actual.val);
            Assert.IsNull(actual.left);
            Assert.IsNull(actual.right);
        }
    }
}
